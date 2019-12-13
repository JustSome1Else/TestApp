using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace TestApp
{
    public partial class MainForm : Form
    {
        StorageContext db;
        ClothesType selectedType;
        List<StoredItemModel> allItems;
        List<StoredItemModel> currentItems;

        public MainForm()
        {
            InitializeComponent();

            db = new StorageContext();
            db.OuterwearStorage.Load();
            db.FootwearStorage.Load();
            db.WorkClothes.Load();
            db.ClothesTypes.Load();
            db.ClothesSubtypes.Load();
            db.Units.Load();

            InitializeUI();
        }

        private void InitializeUI()
        {
            List<ClothesType> cTypes = db.ClothesTypes.ToList();
            cb_WorkClothesType.DataSource = cTypes;
            cb_WorkClothesType.ValueMember = "Id";
            cb_WorkClothesType.DisplayMember = "TypeName";
        }

        private void cb_WorkClothesType_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedType = (ClothesType)cb_WorkClothesType.SelectedItem;

            if (selectedType != null)
            {
                List<ClothesSubtype> cSubtypes = db.ClothesSubtypes.Where(p => p.ClothesTypeId == selectedType.Id).ToList();
                cb_WorkClothesSubtype.DataSource = cSubtypes;
                cb_WorkClothesSubtype.ValueMember = "Id";
                cb_WorkClothesSubtype.DisplayMember = "SubtypeName";

                switch (selectedType.TypeName)
                {
                    case "верхняя одежда":
                        label_Height.Visible = true;
                        nud_HeightMin.Visible = true;
                        label3.Visible = true;
                        nud_HeightMax.Visible = true;

                        btn_Add.Enabled = true;
                        bnt_Edit.Enabled = true;
                        btn_Delete.Enabled = true;

                        break;

                    default:
                        label_Height.Visible = false;
                        nud_HeightMin.Visible = false;
                        label3.Visible = false;
                        nud_HeightMax.Visible = false;

                        btn_Add.Enabled = false;
                        bnt_Edit.Enabled = false;
                        btn_Delete.Enabled = false;

                        break;
                }

                LoadItems(selectedType);
            }
        }

        #region CRUD операции

        // Добавление.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Создаем форму для добавления объекта и инициализируем контролы.
            WorkClothesForm form = new WorkClothesForm();
            form.tb_WorkClothesType.Text = selectedType.TypeName;
            form.cb_WorkClothesSubtype.DataSource = cb_WorkClothesSubtype.DataSource;
            form.cb_WorkClothesSubtype.ValueMember = "Id";
            form.cb_WorkClothesSubtype.DisplayMember = "SubtypeName";

            if (form.ShowDialog() == DialogResult.Cancel)
                return;

            // Проверяем, затронуло ли создание другие таблицы.
            string description = form.tb_Description.Text;
            WorkClothes wClothes = db.WorkClothes.FirstOrDefault(p => p.Description == description);
            if (wClothes == null)
            {
                int subtypeId = (int)form.cb_WorkClothesSubtype.SelectedValue;
                wClothes = new WorkClothes { Description = description, ClothesSubtypeId = subtypeId };
                db.WorkClothes.Add(wClothes);
            }

            // Создаем новый объект.
            Outerwear oWear = new Outerwear();
            oWear.WorkClothes = wClothes;
            oWear.Size = (int)form.nud_Size.Value;
            oWear.Height = (int)form.nud_Height.Value;
            oWear.Quantity = (int)form.nud_Height.Value;

            // Сохраняем.
            db.OuterwearStorage.Add(oWear);
            db.SaveChanges();
            LoadItems(selectedType);
        }

        // Редактирование.
        private void bnt_Edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                // Находим выбранный в гриде объект.
                int selectedRowIndex = dgv.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dgv[0, selectedRowIndex].Value.ToString(), out id);
                if (!converted)
                    return;

                Outerwear oWear = db.OuterwearStorage.Find(id);

                // Создаем форму для редактирования и инициализируем все контролы текущими значениями объекта.
                WorkClothesForm form = new WorkClothesForm();
                form.tb_WorkClothesType.Text = selectedType.TypeName;
                form.cb_WorkClothesSubtype.Items.Add(oWear.WorkClothes.ClothesSubtype.SubtypeName);
                form.cb_WorkClothesSubtype.SelectedIndex = 0;
                form.cb_WorkClothesSubtype.Enabled = false;
                form.tb_Description.Text = oWear.WorkClothes.Description;
                form.tb_Description.Enabled = false;
                form.nud_Size.Value = oWear.Size;
                form.nud_Height.Value = oWear.Height;
                form.nud_Quantity.Value = oWear.Quantity;

                if (form.ShowDialog() == DialogResult.Cancel)
                    return;

                // Сохраняем внесеные изменения.
                oWear.Size = (int)form.nud_Size.Value;
                oWear.Height = (int)form.nud_Height.Value;
                oWear.Quantity = (int)form.nud_Quantity.Value;

                db.SaveChanges();
                LoadItems(selectedType);
            }
        }

        // Удаление.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                // Находим выбранный в гриде объект.
                int selectedRowIndex = dgv.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dgv[0, selectedRowIndex].Value.ToString(), out id);
                if (!converted)
                    return;

                Outerwear oWear = db.OuterwearStorage.Find(id);
                // Удаляем.
                db.OuterwearStorage.Remove(oWear);
                db.SaveChanges();
                LoadItems(selectedType);
            }
        }

        #endregion

        private void btn_LoadTestData_Click(object sender, EventArgs e)
        {
            Helper.AddTestData(db);
            InitializeUI();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db.Dispose();
        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ApplyFilter(ClothesType clothesType)
        {
            switch (clothesType.TypeName)
            {
                case "обувь":
                    currentItems = (from f in allItems
                                      where f.Size >= nud_SizeMin.Value
                                      where f.Size <= nud_SizeMax.Value
                                      where f.Subtype == cb_WorkClothesSubtype.GetItemText(cb_WorkClothesSubtype.SelectedItem)
                                      select f).ToList();
                    break;

                case "верхняя одежда":
                    currentItems = (from f in allItems
                                      where f.Size >= nud_SizeMin.Value
                                      where f.Size <= nud_SizeMax.Value
                                      where f.Height >= nud_HeightMin.Value
                                      where f.Height <= nud_HeightMax.Value
                                      where f.Subtype == cb_WorkClothesSubtype.GetItemText(cb_WorkClothesSubtype.SelectedItem)
                                      select f).ToList();
                    break;

                default:
                    return;
            }

            UpdateGridDataSource(currentItems, clothesType);
        }

        private void LoadItems(ClothesType clothesType)
        {
            switch (clothesType.TypeName)
            {
                case "обувь":
                    allItems = (from storage in db.FootwearStorage
                                   join cloth in db.WorkClothes on storage.WorkClothesId equals cloth.Id
                                   join subtype in db.ClothesSubtypes on cloth.ClothesSubtypeId equals subtype.Id
                                   join type in db.ClothesTypes on subtype.ClothesTypeId equals type.Id
                                   select new StoredItemModel
                                   {
                                       Id = storage.Id,
                                       Type = type.TypeName,
                                       Subtype = subtype.SubtypeName,
                                       Description = cloth.Description,
                                       Quantity = storage.Quantity,
                                       Unit = subtype.Unit.UnitName,
                                       Size = storage.Size
                                   }).ToList();
                    
                    break;

                case "верхняя одежда":
                    allItems = (from storage in db.OuterwearStorage
                                   join cloth in db.WorkClothes on storage.WorkClothesId equals cloth.Id
                                   join subtype in db.ClothesSubtypes on cloth.ClothesSubtypeId equals subtype.Id
                                   join type in db.ClothesTypes on subtype.ClothesTypeId equals type.Id
                                   select new StoredItemModel
                                   {
                                       Id = storage.Id,
                                       Type = type.TypeName,
                                       Subtype = subtype.SubtypeName,
                                       Description = cloth.Description,
                                       Quantity = storage.Quantity,
                                       Unit = subtype.Unit.UnitName,
                                       Size = storage.Size,
                                       Height = storage.Height
                                   }).ToList();
                    break;

                default:
                    return;
            }

            UpdateGridDataSource(allItems, clothesType);
        }

        private void UpdateGridDataSource(List<StoredItemModel> listOfItems, ClothesType clothesType)
        {
            dgv.DataSource = listOfItems;
            dgv.Columns["Height"].Visible = (clothesType.TypeName != "обувь");
        }

        private void btn_ApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter((ClothesType)cb_WorkClothesType.SelectedItem);
        }
    }

    /// <summary>
    /// Класс для проецирования выборки.
    /// </summary>
    public class StoredItemModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
    }
}
