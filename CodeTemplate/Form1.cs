using CodeTemplate.Bll;
using CodeTemplate.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace CodeTemplate
{
    public partial class Form1 : Form
    {
        private readonly Lazy<DbBll> dbBll = new Lazy<DbBll>();
        private readonly Lazy<TemplateBll> templateBll = new Lazy<TemplateBll>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbBussiness a = (DbBussiness)ConfigurationManager.GetSection("DbBussiness");
            foreach (DbBusinessItem item in a.List)
            {
                database.Items.Add(new DbCombobox
                {
                    Name = item.Name,
                    Read = item.Read,
                    Type = item.Type,
                    Write = item.Write
                });
            }
        }

        private void database_SelectedValueChanged(object sender, EventArgs e)
        {
            DbCombobox select = (DbCombobox)database.SelectedItem;
            List<TableModel> tableList = dbBll.Value.GetAllTables(select);

            tabel.Items.AddRange(tableList.ToArray());
        }

        private void tabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = (DbCombobox)database.SelectedItem;
            var tabelName = tabel.SelectedItem.ToString();
            this.modelName.Text = tabelName;
            var tabelFields = dbBll.Value.GetTabelFields(select, tabelName);
            tabelField.DataSource = new BindingList<TabelFieldModel>(tabelFields);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var tabelData = tabelField.DataSource as BindingList<TabelFieldModel>;
            if (tabelData == null)
            {
                MessageBox.Show("未选择表");
                return;
            }

            entityStr.Text = templateBll.Value.GenerateEntity(modelName.Text, tabelData);
            mapStr.Text = templateBll.Value.GenerateMap(tabel.SelectedItem.ToString(), modelName.Text, tabelData);
            repositoryStr.Text = templateBll.Value.GenerateRepository(modelName.Text);
        }
    }
}