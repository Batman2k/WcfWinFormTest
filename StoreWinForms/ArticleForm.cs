using System;
using System.Windows.Forms;
using StoreWinForms.StoreService;

namespace StoreWinForms
{
    public partial class ArticleForm : Form
    {
        private readonly StoreServiceClient _storeService = new StoreServiceClient();

        public ArticleForm()
        {
            InitializeComponent();
        }

        private async void AddArticle()
        {
            var article = new Article();
            decimal parsedPrice;
            decimal.TryParse(textBoxArticlePrice.Text, out parsedPrice);

            article.Price = parsedPrice;
            article.ItemName = textBoxArticleName.Text;
            article.Information = textBoxArticleInformation.Text;
            article.Brand = textBoxArticleBrand.Text;
            article.Model = textBoxArticleModel.Text;

            var articleIdParsed = 0;

            if (int.TryParse(textBoxArticleId.Text, out articleIdParsed))
                article.Articleid = articleIdParsed;


            await _storeService.AddOrUpdateArticleAsync(article);
            UpdateDataGridArticles();
            MessageBox.Show(@"Article " + textBoxArticleName.Text + @" is added");
        }

        private void buttonArticleAdd_Click(object sender, EventArgs e)
        {
            AddArticle();
        }

        private void buttonShowAllArticles_Click(object sender, EventArgs e)
        {
            UpdateDataGridArticles();
        }

        private async void UpdateDataGridArticles()
        {
            dataGridViewArticles.DataSource = await _storeService.ReturnAllArticlesAsync();
        }

        private void buttonEditArticle_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticles.CurrentRow != null)
            {
                var article = (Article) dataGridViewArticles.CurrentRow.DataBoundItem;

                textBoxArticleId.Text = article.Articleid.ToString();
                textBoxArticlePrice.Text = article.Price.ToString("0.00");
                textBoxArticleName.Text = article.ItemName;
                textBoxArticleInformation.Text = article.Information;
                textBoxArticleBrand.Text = article.Brand;
                textBoxArticleModel.Text = article.Model;
            }
        }
        
        private void buttonRemoveArticle_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticles.CurrentRow != null)
            {
                var removearticle = (Article) dataGridViewArticles.CurrentRow.DataBoundItem;
                _storeService.RemoveArticleById(removearticle.Articleid);
            }
            UpdateDataGridArticles();
        }
    }
}