using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using winForms.Model;
using System.Linq;

// ApplicationConfiguration.Initialize();

// var form = new Form();
// form.WindowState = FormWindowState.Maximized;
// form.FormBorderStyle = FormBorderStyle.None;
// form.BackColor = Color.OldLace;
// form.TransparencyKey = Color.OldLace;
// PictureBox pb = new PictureBox();
// pb.Dock = DockStyle.Fill;
// pb.Image = Image.FromFile("jequiti-logo.png");
// pb.SizeMode = PictureBoxSizeMode.Zoom;
// form.Controls.Add(pb);


// Timer timer = new Timer();
// timer.Interval =  310;
// var show = false;


// timer.Tick += delegate
// {
//     if (show)
//     {
//         form.Hide();
//         show = false;
//     }
//     var rand = Random.Shared;
//     if (rand.Next(100) < 2)
//     {
//         form.Show();
//         show = true;
//     }
// };

// form.Load += delegate
// {
//     form.Hide();
//     timer.Start();
// };

// var bt = new Button();
// bt.Text = "me aperte pra fechar";

// bt.Width = 200;
// form.Controls.Add(bt);
// bt.Anchor = AnchorStyles.Left;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////::?


// form.KeyPreview = true;
// form.KeyDown += (s, e) =>
// {
//     if (e.KeyCode == Keys.Escape)
//         Application.Exit();
// };

// Panel pn = new Panel();
// pn.BackgroundImage = Image.FromFile("DVD_logo.svg");
// pn.BackColor = Color.Pink;
// pn.Width = 100;
// pn.Height = 100;

// form.Controls.Add(pn);

// Random rnd = new Random();

// var dirX = 40;
// var dirY = 40;


// var timer = new Timer();
// timer.Interval = 1;
// timer.Tick += delegate
// {
//     var x = pn.Location.X;
//     var y = pn.Location.Y;

//     var num1 = rnd.Next(0, 255);
//     var num2 = rnd.Next(0, 255);
//     var num3 = rnd.Next(0, 255);
//     if (y >= (form.Height - 100) || y < 0)
//     {
//         dirY *= -1;
//         pn.BackColor = Color.FromArgb(num1, num2, num3);
//     }
//     if (x >= (form.Width - 100) || x < 0)
//     {
//         dirX *= -1;
//         pn.BackColor = Color.FromArgb(num1, num2, num3);
//     }

//     y += dirY;
//     x += dirX;


//     pn.Location = new Point(x, y);
// };

// form.Load += delegate
// {
//     timer.Start();
// };



// // var img  = new Bitmap("C:\\Users\\disrct\\Pictures\\Hydrangeas.jpg");
// // form.BackgroundImage = img;
// Application.Run(form);


// ---------------------   USANDO FLOW LAYOUT PANEL     --------------------------



ApplicationConfiguration.Initialize();

var form = new Form();
var addBtn = new Button();
var stoqView = new Button();
var prodInput = new TextBox();
var stoqInput = new TextBox();
var precInput = new TextBox();


// exitBtn.Text = "me aperte pra fechar";
// exitBtn.Width = 150;

stoqView.Text = "gerenciar estoque";
stoqView.Width = 150;

addBtn.Text = "me aperte pra adicionar";
addBtn.Width = 150;

var prodLabel = new Label();
    prodLabel.Text = "Produto: ";

var stoqLabel = new Label();
    stoqLabel.Text = "Estoque: ";

var precLabel = new Label();
    precLabel.Text = "Preço: ";

var flowLayoutPanel = new FlowLayoutPanel();
    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
    flowLayoutPanel.WrapContents = false;
    flowLayoutPanel.AutoScroll = true;
    flowLayoutPanel.AutoSize = true;
    
var prodPanel = new FlowLayoutPanel();
    prodPanel.AutoSize = true;
    prodPanel.Controls.Add(prodLabel);
    prodPanel.Controls.Add(prodInput);

var stoqPanel = new FlowLayoutPanel();
    stoqPanel.AutoSize = true;
    stoqPanel.Controls.Add(stoqLabel);
    stoqPanel.Controls.Add(stoqInput);

var precPanel = new FlowLayoutPanel();
    precPanel.AutoSize = true;
    precPanel.Controls.Add(precLabel);
    precPanel.Controls.Add(precInput);

var btnPanel = new FlowLayoutPanel();
    // btnPanel.FlowDirection = FlowDirection.TopDown;
    // btnPanel.Dock = DockStyle.Fill;
    btnPanel.Controls.Add(stoqView);
    btnPanel.Controls.Add(addBtn);
    btnPanel.AutoSize = true;

prodInput.Width = 200;
stoqInput.Width = 200;
precInput.Width = 200;


flowLayoutPanel.Controls.Add(prodPanel);
flowLayoutPanel.Controls.Add(stoqPanel);
flowLayoutPanel.Controls.Add(precPanel);
flowLayoutPanel.Controls.Add(btnPanel);

flowLayoutPanel.Dock = DockStyle.Fill;
form.Controls.Add(flowLayoutPanel);
// form.Controls.Add(stoqView);

form.AutoSize = true;

ProductService prodService = new ProductService();
EstoqueService stoqService = new EstoqueService();
Produto prod = new Produto();
Estoque estq = new Estoque();


addBtn.Click +=  async (s, e) => 
{

    prod.Name = prodInput.Text;
    prod.Preco = int.Parse(precInput.Text);

    var resultProd = await prodService.AddProduct(prod);
    var produt = await prodService.Filter(x => x.Name == prod.Name);
    var prodResult = produt.FirstOrDefault();

    estq.ProdutoId = prodResult.Id;
    estq.Quantidade =int.Parse(stoqInput.Text);

    var resultStoq = await stoqService.AddEstoque(estq);

    if(resultProd && resultStoq)
        MessageBox.Show("cadastro realizado com sucesso");
    else
        MessageBox.Show("erro"); 
}; 


form.KeyPreview = true;
form.KeyDown += (s, e) =>
{
    if (e.KeyCode == Keys.Escape)
        Application.Exit();
};


Application.Run(form);

PictureBox pb = new PictureBox();
form.Controls.Add(pb);

// ---------------------   USANDO TABLE LAYOUT     --------------------------




// ApplicationConfiguration.Initialize();

// var form = new Form();
// var bt = new Button();

// var prodInput = new TextBox();
// var stoqInput = new TextBox();
// var precInput = new TextBox();

// var prodLabel = new Label();
// prodLabel.Text = "Produto:";

// var stoqLabel = new Label();
// stoqLabel.Text = "Estoque:";

// var precLabel = new Label();
// precLabel.Text = "Preço:";

// var tableLayout = new TableLayoutPanel();
// tableLayout.ColumnCount = 2;
// tableLayout.RowCount = 4;
// tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
// tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
// tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
// tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
// tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
// tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

// tableLayout.Controls.Add(prodLabel, 0, 0);
// tableLayout.Controls.Add(prodInput, 1, 0);
// tableLayout.Controls.Add(stoqLabel, 0, 1);
// tableLayout.Controls.Add(stoqInput, 1, 1);
// tableLayout.Controls.Add(precLabel, 0, 2);
// tableLayout.Controls.Add(precInput, 1, 2);

// var flowLayoutPanel = new FlowLayoutPanel();
// flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
// flowLayoutPanel.WrapContents = false;
// flowLayoutPanel.AutoScroll = true;
// flowLayoutPanel.AutoSize = true;

// flowLayoutPanel.Controls.Add(tableLayout);

// form.Controls.Add(flowLayoutPanel);

// bt.Text = "Me aperte pra fechar";
// bt.Width = 200;
// flowLayoutPanel.Controls.Add(bt);

// bt.Click += (s, e) => 
// {
//     Application.Exit();
// }; 

// form.KeyPreview = true;
// form.KeyDown += (s, e) =>
// {
//     if (e.KeyCode == Keys.Escape)
//         Application.Exit();
// };

// form.Size = new System.Drawing.Size(300, 500);
// PictureBox pb = new PictureBox();
// form.Controls.Add(pb);

// Application.Run(form);
