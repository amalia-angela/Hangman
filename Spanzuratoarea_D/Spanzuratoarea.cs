using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jocul_Spanzuratoarea_D
{
    public partial class Jocul_Spanzuratoarea : Form
    {
        enum SpanzuratoareaStatus
        {
            Nimic,
            Agatator,
            Franghie,
            Cap,
            Corp,
            ManaStanga,
            ManaDreapta,
            PiciorStang,
            PiciorDrept
        
        }

        // litera curenta
        List<Label> labels = new List<Label>();

        // cuvantul curent pe care il folosim
        public string currentWord { get; set; }

        // __  ascundem literele
        public string DefaultChar { get { return "__"; } }

        private SpanzuratoareaStatus CurrentHangState = SpanzuratoareaStatus.Nimic;

        public int HangStateSize { get { return (Enum.GetValues(typeof(SpanzuratoareaStatus)).Length - 1); } }
        
        // Global graphics info
        Pen p;
        Pen pFranghie;
        int panelLocX = 0;
        int panelLocY = 0;
        int panelWidth = 0;
        int panelHeight = 0;

        // Coordinatele XY a agatatorului
        int agatatorVerBottomX;
        int agatatorVerBootomY;
        int agatatorVerTopX;
        int agatatorVerTopY;
        int agatatorHorRightX;
        int agatatorHorRightY;
        int agatatorHorLeftX;
        int agatatorHorLeftY;

        // franghie info
        int franghieTopX;
        int franghieTopY;
        int franghieBottomX;
        int franghieBottomY;

        // Cap info
        int diametru = 50;
        int CapRectX;

        // Corp info
        int corpRectY;
        int corpSize;

        public Jocul_Spanzuratoarea()
        {
            InitializeComponent();
            AddButtons();
        }

       
        //tastatur
        private void AddButtons()
        {
            for (int index = (int)'A'; index <= (int)'Z'; index++)
            {
                Button b = new Button();
                b.Text = ((char)index).ToString();
                b.Parent = flowLayoutPanel1;
                b.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular);
                b.Size = new Size(40, 40);
                b.BackColor = Color.Pink;                
                b.Click += b_Click; //creste clickul cand se agata "ceva"
            }

            flowLayoutPanel1.Enabled = false;
        }

        //click pe tastaura
        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            char charClicked = b.Text.ToCharArray()[0];
            b.Enabled = false;

            if ((currentWord = currentWord.ToUpper()).Contains(charClicked))
            {
                // cand e correct completam cu litera
                lblInfo.Text = "Corect!";
                lblInfo.ForeColor = Color.Green;
                char[] charArray = currentWord.ToCharArray();
                for (int index = 0; index < currentWord.Length; index++)
                {
                    if (charArray[index] == charClicked)
                        labels[index].Text = charClicked.ToString();
                }

                // conditie de castigare              
                if (labels.Where(x => x.Text.Equals(DefaultChar)).Any())
                    return;

                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "Ai castigat! <3";
                flowLayoutPanel1.Enabled = false;
            }
            else
            {
                // cand e incorect
                lblInfo.Text = "Incorect!";
                lblInfo.ForeColor = Color.Red;
                if (CurrentHangState != SpanzuratoareaStatus.PiciorDrept)
                    CurrentHangState++;
                txtNrIncercariRamase.Text = (HangStateSize - (int)CurrentHangState).ToString();
                txtLitereIncorecte.Text += string.IsNullOrWhiteSpace(txtLitereIncorecte.Text) ? charClicked.ToString() : " " + charClicked;

                panel1.Invalidate();

                //daca si piciorul dreap e desenat ai pierdut
                if (CurrentHangState == SpanzuratoareaStatus.PiciorDrept)
                {
                    lblInfo.Text = "Ai pierdut!\nIncearca din nou!";
                    lblInfo.ForeColor = Color.Red;
                    flowLayoutPanel1.Enabled = false;

                    // afisam cu rosu ce nu a ghicit
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (labels[i].Text.Equals(DefaultChar))
                        {
                            labels[i].Text = currentWord[i].ToString();
                            labels[i].ForeColor = Color.Red;
                        }
                    }
                }
            }
        }        

        private void InitializeVars()
        {
            // setam global graphics info          
            p = new Pen(Color.Black, 20);
            pFranghie = new Pen(Color.Black, 5);
            panelLocX = panel1.Location.X;
            panelLocY = panel1.Location.Y;
            panelWidth = panel1.Width;
            panelHeight = panel1.Height;

            // setam coordinatele agataorului 
            agatatorVerBottomX = panelWidth - 30;
            agatatorVerBootomY = panelHeight - 15;
            agatatorVerTopX = agatatorVerBottomX;
            agatatorVerTopY = panelHeight - panelHeight + 30;
            agatatorHorRightX = panelWidth - 30 + 10;
            agatatorHorRightY = panelHeight - panelHeight + 50;
            agatatorHorLeftX = panelWidth - panelWidth + 50;
            agatatorHorLeftY = agatatorHorRightY;

            // frangie info
            franghieTopX = (agatatorHorRightX + agatatorHorLeftX) / 3;
            franghieTopY = agatatorHorLeftY;
            franghieBottomX = franghieTopX;
            franghieBottomY = franghieTopY + 40; 

            // cap info
            diametru = 50;
            CapRectX = franghieBottomX - diametru / 2;

            // cap info
            corpRectY = franghieBottomY + diametru;
            corpSize = (agatatorVerBootomY - agatatorVerTopY) / 2;
        }        

        //exit button action
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //start button action
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Enabled)
                if (MessageBox.Show("Vrei sa incerci din nou?", "Jocul a inceput!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                    return;

            ResetControls();
            SelectWord();
            AddLabels();
        }

        //aduagam cuvantul in labels si labels in group Box
        private void AddLabels()
        {
          
            groupBox1.Controls.Clear();
            labels.Clear();
            char[] wordChars = currentWord.ToCharArray();
            int len = wordChars.Length;
            int refer = groupBox1.Width / len;

            for (int index = 0; index < len; index++)
            {
                Label l = new Label();
                l.Text = DefaultChar;
                l.Location = new Point(10 + index * refer, groupBox1.Height - 30);
                l.Parent = groupBox1;
                l.BringToFront();
                labels.Add(l);
            }

            // afisare in text boxuri
            txtLungimeCuv.Text = len.ToString();
            txtNrIncercariRamase.Text = HangStateSize.ToString();
        }

        //resetarea jocului
        private void ResetControls()
        {
     
            flowLayoutPanel1.Controls.Clear();
            AddButtons();
            CurrentHangState = SpanzuratoareaStatus.Nimic;
            panel1.Invalidate();
            txtLitereIncorecte.Clear();
            lblInfo.Text = "";
            flowLayoutPanel1.Enabled = true;
        }

        //select cuvant random
        private void SelectWord()
        {                      
            string filePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Words.txt");
            using (TextReader tr = new StreamReader(filePath, Encoding.ASCII))
            {
                Random r = new Random();
                var allWords = tr.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);                
                currentWord = allWords[r.Next(0, allWords.Length - 1)];
            }
        }

        //desenarea spanzuartoarei
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            InitializeVars();
            var g = e.Graphics; 

            if (CurrentHangState >= SpanzuratoareaStatus.Agatator)
            {
                g.DrawLine(p, new Point(agatatorVerBottomX, agatatorVerBootomY), new Point(agatatorVerTopX, agatatorVerTopY));
                g.DrawLine(p, new Point(agatatorHorRightX, agatatorHorRightY), new Point(agatatorHorLeftX, agatatorHorLeftY));
            }

            if (CurrentHangState >= SpanzuratoareaStatus.Franghie)
            {
                g.DrawLine(pFranghie, new Point(franghieTopX, franghieTopY), new Point(franghieBottomX, franghieBottomY));
            }

            if (CurrentHangState >= SpanzuratoareaStatus.Cap)
            {
                g.DrawEllipse(pFranghie, new Rectangle(new Point(CapRectX, franghieBottomY), new Size(diametru, diametru)));
                g.FillRectangles(new SolidBrush(Color.Crimson),
                    new[] {
                            new Rectangle( new Point(CapRectX + 10, franghieBottomY + 10), new Size(6, 6)), // Left eye
                            new Rectangle( new Point(CapRectX + diametru - 10 - 6, franghieBottomY + 10), new Size(6, 6)), // Right eye
                            new Rectangle(new Point(franghieBottomX - 5/2, franghieBottomY + diametru/2), new Size(5, 5)),  // Nose
                            new Rectangle(new Point(franghieBottomX - 10, franghieBottomY + diametru/2 + 10), new Size(20, 5))   // Mouth
                        });
            }

            if (CurrentHangState >= SpanzuratoareaStatus.Corp)
            {
                g.DrawEllipse(pFranghie, new Rectangle(new Point(CapRectX, corpRectY), new Size(diametru, corpSize)));
            }

            if (CurrentHangState >= SpanzuratoareaStatus.ManaStanga)
            {
                g.DrawCurve(pFranghie,
                new[] { 
                            new Point(CapRectX + 8, corpRectY + 15), 
                            new Point(CapRectX - 30, corpRectY + 30),
                            new Point(CapRectX - 30, corpRectY + 20),
                            
                            new Point(CapRectX + 5, corpRectY + 25)
                        });
            }

            if (CurrentHangState >= SpanzuratoareaStatus.ManaDreapta)
            {
                g.DrawCurve(pFranghie,
                 new[] { 
                            new Point(CapRectX + diametru - 8, corpRectY + 15), 
                            new Point(CapRectX + diametru + 30, corpRectY + 30),
                            new Point(CapRectX + diametru + 30, corpRectY + 20),
                            
                            new Point(CapRectX + diametru - 5, corpRectY + 25)
                        });
            }

            if (CurrentHangState >= SpanzuratoareaStatus.PiciorStang)
            {
                g.DrawCurve(pFranghie,
                new[] { 
                            new Point(CapRectX + 8, corpRectY + corpSize - 15), 
                            new Point(CapRectX - 30, corpRectY + corpSize - 5),
                            new Point(CapRectX - 30, corpRectY + corpSize),
                            new Point(CapRectX + 5, corpRectY + corpSize - 25)
                        });
            }

            if (CurrentHangState >= SpanzuratoareaStatus.PiciorDrept)
            {
                g.DrawCurve(pFranghie,
                  new[] { 
                            new Point(CapRectX + diametru - 8, corpRectY + corpSize - 15), 
                            new Point(CapRectX + diametru + 30, corpRectY + corpSize - 5),
                            new Point(CapRectX + diametru + 30, corpRectY + corpSize),
                            new Point(CapRectX + diametru - 5, corpRectY + corpSize - 25)
                        });
            }
        }       
    }
}
