using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using winForms.Model;
using System.Linq;
using System.Collections.Generic;

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



// ApplicationConfiguration.Initialize();

// var form = new Form();
// var addBtn = new Button();
// var stoqView = new Button();
// var prodInput = new TextBox();
// var stoqInput = new TextBox();
// var precInput = new TextBox();

// ListViewItem ListView = new ListViewItem();

// // exitBtn.Text = "me aperte pra fechar";
// // exitBtn.Width = 150;

// stoqView.Text = "gerenciar estoque";
// stoqView.Width = 150;

// addBtn.Text = "me aperte pra adicionar";
// addBtn.Width = 150;

// var prodLabel = new Label();
//     prodLabel.Text = "Produto: ";

// var stoqLabel = new Label();
//     stoqLabel.Text = "Estoque: ";

// var precLabel = new Label();
//     precLabel.Text = "Preço: ";

// var flowLayoutPanel = new FlowLayoutPanel();
//     flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
//     flowLayoutPanel.WrapContents = false;
//     flowLayoutPanel.AutoScroll = true;
//     flowLayoutPanel.AutoSize = true;

// var prodPanel = new FlowLayoutPanel();
//     prodPanel.AutoSize = true;
//     prodPanel.Controls.Add(prodLabel);
//     prodPanel.Controls.Add(prodInput);

// var stoqPanel = new FlowLayoutPanel();
//     stoqPanel.AutoSize = true;
//     stoqPanel.Controls.Add(stoqLabel);
//     stoqPanel.Controls.Add(stoqInput);

// var precPanel = new FlowLayoutPanel();
//     precPanel.AutoSize = true;
//     precPanel.Controls.Add(precLabel);
//     precPanel.Controls.Add(precInput);

// var btnPanel = new FlowLayoutPanel();
//     // btnPanel.FlowDirection = FlowDirection.TopDown;
//     // btnPanel.Dock = DockStyle.Fill;
//     btnPanel.Controls.Add(stoqView);
//     btnPanel.Controls.Add(addBtn);
//     btnPanel.AutoSize = true;

// prodInput.Width = 200;
// stoqInput.Width = 200;
// precInput.Width = 200;


// flowLayoutPanel.Controls.Add(prodPanel);
// flowLayoutPanel.Controls.Add(stoqPanel);
// flowLayoutPanel.Controls.Add(precPanel);
// flowLayoutPanel.Controls.Add(btnPanel);

// flowLayoutPanel.Dock = DockStyle.Fill;
// form.Controls.Add(flowLayoutPanel);
// // form.Controls.Add(stoqView);

// form.AutoSize = true;

// ProductService prodService = new ProductService();
// EstoqueService stoqService = new EstoqueService();
// Produto prod = new Produto();
// Estoque estq = new Estoque();


// addBtn.Click +=  async (s, e) => 
// {

//     prod.Name = prodInput.Text;
//     prod.Preco = int.Parse(precInput.Text);

//     var resultProd = await prodService.AddProduct(prod);
//     var produt = await prodService.Filter(x => x.Name == prod.Name);
//     var prodResult = produt.FirstOrDefault();

//     estq.ProdutoId = prodResult.Id;
//     estq.Quantidade =int.Parse(stoqInput.Text);

//     var resultStoq = await stoqService.AddEstoque(estq);

//     if(resultProd && resultStoq)
//         MessageBox.Show("cadastro realizado com sucesso");
//     else
//         MessageBox.Show("erro"); 
// }; 


// stoqView.Click += async(s, e) =>
// {
//     var temp = await stoqService.VerificaEstoque(x => x.Id > 0);       
//     // ListView.Columns.Add();
// };

// form.KeyPreview = true;
// form.KeyDown += (s, e) =>
// {
//     if (e.KeyCode == Keys.Escape)
//         Application.Exit();
// };


// Application.Run(form);

// PictureBox pb = new PictureBox();
// form.Controls.Add(pb);

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


// public class MyControl : UserControl
// {

// }


// ---------------------   MOUSE POSITION     --------------------------



// ApplicationConfiguration.Initialize();

// var form = new Form();

// var flowLayoutPanel = new FlowLayoutPanel();
//     flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
//     flowLayoutPanel.WrapContents = false;
//     flowLayoutPanel.AutoScroll = true;
//     flowLayoutPanel.AutoSize = true;

// Point? p = null;

// var Btn1 = new Button();
// var stoqView = new Button();

// Btn1.Text = "to aq";
// Btn1.Width = 150;

// // var APanel = new FlowLayoutPanel();
// //     APanel.BackColor = Color.Blue;
// //     APanel.AutoSize = true;

// var BPanel = new FlowLayoutPanel();
//     BPanel.BackColor = Color.Green;
//     BPanel.AutoSize = true;

// BPanel.Location = new Point(50,100);

// Btn1.MouseMove += (s, e) =>
// {
//     if (p is null)
//         return;

//     var dx = e.Location.X - p.Value.X;
//     var dy = e.Location.Y - p.Value.Y;
//     Btn1.Location = new Point(
//         Btn1.Location.X + dx, 
//         Btn1.Location.Y + dy
//     );
// };

// form.KeyPreview = true;
// form.KeyDown += (s, e) =>
// {
//     if (e.KeyCode == Keys.Escape)
//         Application.Exit();
// };

// Btn1.MouseDown += (s, e) =>
// {

//     p = e.Location;

//     var parent = Btn1.Parent;
//     if(parent == BPanel)
//     {
//         BPanel.Controls.Remove(Btn1);
//         form.Controls.Add(Btn1);
//         Btn1.BringToFront();

//     }
// };

// Btn1.MouseUp += (s, e) =>
// {
//     p = null;
//     if(Btn1.Top > BPanel.Top && Btn1.Bottom < BPanel.Bottom )   
//     {
//         BPanel.Controls.Add(Btn1);
//         MessageBox.Show("TA NO BPANEL");
//         return;
//     }

// };

// form.Controls.Add(BPanel);
// form.Controls.Add(Btn1);
// Btn1.BringToFront();
// Application.Run(form);


// Bitmap bmp = null;
// Graphics g = null;



// ---------------------   SPRITES LAYOUT     --------------------------

 

ApplicationConfiguration.Initialize();

var form = new Form();

form.WindowState = FormWindowState.Maximized;
form.FormBorderStyle = FormBorderStyle.None;

Graphics g = null;
Bitmap bmp = null;
PictureBox pb = new PictureBox();
pb.Dock = DockStyle.Fill;
form.Controls.Add(pb);

Image img = Bitmap.FromFile("./zelda.png");

Point cursor = Point.Empty;
pb.MouseMove += (s, e) =>
{
    cursor = e.Location;
};
var tm = new Timer();
tm.Interval = 30;

int x = 0;
int y = 0;
int speed = 0;

int posXPng = 1;
int posYPng = 0;
int tamXPng = 2;
int tamYPng = 1;
int spriteWidth = 120;
int spriteHeight = 130;
Queue<DateTime> queue = new Queue<DateTime>();
queue.Enqueue(DateTime.Now);

var latestChange = DateTime.Now;

tm.Tick += delegate 
{
    Rectangle tela = new Rectangle(speed, y, spriteWidth, spriteHeight);
    
    Rectangle imgOriginal = new Rectangle(spriteWidth * posXPng, spriteHeight * posYPng, spriteWidth, spriteHeight);
    g.FillRectangle(Brushes.Black, tela);
    g.DrawImage(img, tela, imgOriginal, GraphicsUnit.Pixel);
    var now = DateTime.Now;
    queue.Enqueue(now);
    
    if (queue.Count > 19)
    {
        DateTime old = queue.Dequeue();
        var time = now - old;
        var fps = (int)(19 / time.TotalSeconds);
    }
    if ((now - latestChange).TotalMilliseconds >= 1000/tamXPng)
    {
        posXPng = posXPng < tamXPng ? posXPng += 1 : 1;
        speed += speed;
        latestChange = DateTime.Now;
    }
    pb.Refresh();
    g.Clear(Color.White);
};

form.Load += delegate
{
    form.KeyPreview = true;
    bmp = new Bitmap(pb.Width, pb.Height);
    g = Graphics.FromImage(bmp);
    pb.Image = bmp;
    tm.Start();
};

// form.KeyPreview = true;
form.KeyDown += (s, e) =>
{
    if (e.KeyCode == Keys.Escape)
        Application.Exit();
    

    if (e.KeyCode == Keys.D)
    {
        speed = 10;
        posYPng = 7;
        tamXPng = 9;
    }
    if (e.KeyCode == Keys.A)
    {
        speed = -10;
        posYPng = 5;
        tamXPng = 9;
    }

    if (e.KeyCode == Keys.W)
    {
        speed = 10;
        posYPng = 6;
        tamXPng = 9;
    }
    if (e.KeyCode == Keys.S)
    {
        speed = 10;
        posYPng = 4;
        tamXPng = 9;
    }
};


form.KeyUp += (s, e) => 
{
    speed = 0;
    if (e.KeyCode == Keys.A)
    {
        posYPng = 2;
    }
    posXPng = 1;
    posYPng = 0;
    tamXPng = 2;
    tamYPng = 1;
};

Application.Run(form);