using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using DapperSamples.Entities;

namespace DapperSamples
{
    public partial class Main : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["DapperConnection"].ConnectionString;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retorna uma lista com objetos dinâmicos
        /// </summary>
        private List<Product> DinamicSelect()
        {
            using (var conn = new SqlConnection(strConn))
            {
                var result = conn.Query<Product, Category, Product>("SELECT * FROM PRODUCTS P INNER JOIN CATEGORIES C ON P.CATEGORYID = C.CATEGORYID", map: (product, category) =>
                {
                    product.Category = category;
                    return product;
                },
                splitOn: "ProductId, CategoryId");

                List<Product> lstProduct = new List<Product>();

                foreach (dynamic product in result)
                {
                    lstProduct.Add(product);
                }

                conn.Close();

                return lstProduct;
            }
        }

        /// <summary>
        /// Retorna uma lista com objetos tipados
        /// </summary>
        private IEnumerable<Product> TypedSelect()
        {
            using (var conn = new SqlConnection(strConn))
            {
                IEnumerable<Product> products = conn.Query<Product>("SELECT * FROM PRODUCTS");
                
                return products;
            }
        }

        /// <summary>
        /// Retorna uma lista utilizando parâmetros
        /// </summary>
        private IEnumerable<Product> ParametersSelect()
        {
            using (var conn = new SqlConnection(strConn))
            {
                IEnumerable<Product> products = conn.Query<Product>("SELECT PRODUCTID, NAME FROM PRODUCTS WHERE NAME LIKE @Search", new { Search = "%note%" });
                
                return products;
            }
        }

        /// <summary>
        /// Retorna um registro a partir de seu ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        private Product GetById(int productId)
        {
            using (var conn = new SqlConnection(strConn))
            {
                var product = conn.Query<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID=@ProductId", new { ProductId = productId }).SingleOrDefault();
                
                return product;
            }
        }

        /// <summary>
        /// Insere um registro no banco
        /// </summary>
        /// <param name="productName"></param>
        private Product Insert(Product product)
        {
            using (var conn = new SqlConnection(strConn))
            {
                var newId = conn.Query<int>(@"INSERT INTO PRODUCTS (CATEGORYID, NAME) VALUES (@CategoryId, @Name); SELECT CAST(SCOPE_IDENTITY() AS INT)", product).SingleOrDefault();
                product.ProductId = newId;

                return product;
            }
        }

        /// <summary>
        /// Atualizada um registro no banco
        /// </summary>
        /// <param name="productName"></param>
        private bool Update(Product product)
        {
            using (var conn = new SqlConnection(strConn))
            {
                var affectedrows = conn.Execute(@"UPDATE PRODUCTS SET NAME = @Name WHERE PRODUCTID = @ProductId", product);
                return affectedrows > 0;
            }
        }

        /// <summary>
        /// Exclui um registro do banco
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        private bool Delete(int productId)
        {
            using (var conn = new SqlConnection(strConn))
            {
                var affectedrows = conn.Execute("DELETE FROM PRODUCTS WHERE PRODUCTID = @ProductId", new { ProductId = productId });
                
                return affectedrows > 0;
            }
        }

        private void btnBasicSelect_Click(object sender, System.EventArgs e)
        {
            txbResultQuery.Clear();
            var products = DinamicSelect();

            foreach (Product product in products)
            {
                txbResultQuery.AppendText(product.ProductId + "; " + product.Category.Name + ";" + product.Name + "\r\n");
            }
        }

        private void btnTypedSelect_Click(object sender, System.EventArgs e)
        {
            txbResultQuery.Clear();
            var products = TypedSelect();

            foreach (Product product in products)
            {
                txbResultQuery.AppendText(product.ProductId + "; " + product.Name + "\r\n");
            }
        }

        private void btnParametersSelect_Click(object sender, System.EventArgs e)
        {
            txbResultQuery.Clear();
            var products = ParametersSelect();

            foreach (Product product in products)
            {
                txbResultQuery.AppendText(product.ProductId + "; " + product.Name + "\r\n");
            }
        }

        private void btnInsert_Click(object sender, System.EventArgs e)
        {
            Product product = new Product { CategoryId = 1, Name = "Notebook New" };
            Insert(product);

            if (product.ProductId > 0)
                MessageBox.Show("Record inserted!");
        }

        private void btnGetById_Click(object sender, System.EventArgs e)
        {
            int id = 1;

            Product product = GetById(id);

            txbResultQuery.Clear();
            txbResultQuery.AppendText(product.ProductId + " ; " + product.Name);
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            int id = 1;

            Product product = GetById(id);
            product.Name = "New Name";

            if (Update(product))
                MessageBox.Show("Record updated!");
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (Delete(2))
                MessageBox.Show("Record deleted!");
        }
    }
}
