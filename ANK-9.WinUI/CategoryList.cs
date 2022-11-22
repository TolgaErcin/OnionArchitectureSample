using ANK_9.BLL.Abstract;
using ANK_9.Entities;
using ANK_9.Sysstem;
using ANK_9.ViewModels.CategoryVMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANK_9.WinUI
{
    public partial class CategoryList : Form
    {
        private readonly ICategoryBLL _categoryBLL;
        public CategoryList(ICategoryBLL categoryBLL)
        {
            InitializeComponent();
            _categoryBLL = categoryBLL;
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            RefreshFormElement();
        }
        private void RefreshFormElement()
        {
            lst_Category.Items.Clear();
            ResultService<Category> resultService = _categoryBLL.GetAllCategoryName();
            if (resultService != null)
            {
                List<Category> categories = new List<Category>();
                categories = resultService.ListData;
                foreach (Category category in categories)
                {
                    lst_Category.Items.Add(category.CategoryName);
                }
                txt_CategoryId.Clear();
                txt_CategoryName.Clear();
            }
            else
            {
                string error = resultService.Errors.ToList()[0].ErrorMessage + " " + resultService.Errors.ToList()[0].ErrorType;
                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lst_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CategoryId.Text = _categoryBLL.GetCategoryID(lst_Category.SelectedItem.ToString()).Data.Id.ToString();
            txt_CategoryName.Text = _categoryBLL.GetCategoryID(lst_Category.SelectedItem.ToString()).Data.Name;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CategoryNewVm categoryNewVm = new CategoryNewVm();
            categoryNewVm.Name = txt_CategoryName.Text;
            ResultService<Category> result=_categoryBLL.CreateCategory(categoryNewVm);
            GetResult(result);
            RefreshFormElement();
        }

        private void GetResult(ResultService<Category> result)
        {
            if (result.Data==null)
            {
                string error = result.Errors.ToList()[0].ErrorMessage+" "+result.Errors.ToList()[0].ErrorType;
                MessageBox.Show(error,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ResultService<Category> resultService = _categoryBLL.GetCategoryByName(lst_Category.SelectedItem.ToString());
            if (resultService.Data!=null)
            {
                CategoryUpdateVM updateVM= new CategoryUpdateVM()
                {
                    Id=resultService.Data.ID,
                    Name=txt_CategoryName.Text
                };
                ResultService<CategoryUpdateVM> result = _categoryBLL.UpdateCategory(updateVM);
                if (!result.HasError)
                {
                    MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshFormElement();
                }
                else
                {
                    string error = result.Errors.ToList()[0].ErrorMessage + " " + result.Errors.ToList()[0].ErrorType;
                    MessageBox.Show(error,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                GetResult(resultService);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ResultService<Category> result = _categoryBLL.GetCategoryByName(lst_Category.SelectedItem.ToString());
            if (result.Data!=null)
            {
                ResultService<CategoryBaseVM> resultService = _categoryBLL.DeleteCategory(result.Data.ID);
                if (!resultService.HasError)
                {
                    MessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshFormElement();
                }
                else
                {
                    string error = resultService.Errors.ToList()[0].ErrorMessage + " " + resultService.Errors.ToList()[0].ErrorType;
                    MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                GetResult(result);
            }
        }
    }
}
