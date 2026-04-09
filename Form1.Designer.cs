namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            gbxMenu = new GroupBox();
            pbxChickenBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            pbxBulgogiBurger = new PictureBox();
            rdoBulgogiBurger = new RadioButton();
            pbxHamBurger = new PictureBox();
            rdoHamBurger = new RadioButton();
            gbxOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            gbxOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            lblError = new Label();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHamBurger).BeginInit();
            gbxOption.SuspendLayout();
            gbxOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 20F);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(31, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // gbxMenu
            // 
            gbxMenu.Controls.Add(pbxChickenBurger);
            gbxMenu.Controls.Add(rdoChickenBurger);
            gbxMenu.Controls.Add(pbxBulgogiBurger);
            gbxMenu.Controls.Add(rdoBulgogiBurger);
            gbxMenu.Controls.Add(pbxHamBurger);
            gbxMenu.Controls.Add(rdoHamBurger);
            gbxMenu.Font = new Font("맑은 고딕", 12F);
            gbxMenu.ForeColor = Color.Maroon;
            gbxMenu.Location = new Point(31, 115);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Size = new Size(448, 537);
            gbxMenu.TabIndex = 1;
            gbxMenu.TabStop = false;
            gbxMenu.Text = "메뉴 선택";
            // 
            // pbxChickenBurger
            // 
            pbxChickenBurger.Image = Properties.Resources.img_ChickenBurger;
            pbxChickenBurger.Location = new Point(234, 392);
            pbxChickenBurger.Name = "pbxChickenBurger";
            pbxChickenBurger.Size = new Size(175, 139);
            pbxChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxChickenBurger.TabIndex = 5;
            pbxChickenBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F);
            rdoChickenBurger.ForeColor = Color.Brown;
            rdoChickenBurger.Location = new Point(20, 422);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(179, 49);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // pbxBulgogiBurger
            // 
            pbxBulgogiBurger.Image = Properties.Resources.img_BulgogiBurger;
            pbxBulgogiBurger.Location = new Point(234, 229);
            pbxBulgogiBurger.Name = "pbxBulgogiBurger";
            pbxBulgogiBurger.Size = new Size(175, 139);
            pbxBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBulgogiBurger.TabIndex = 3;
            pbxBulgogiBurger.TabStop = false;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F);
            rdoBulgogiBurger.ForeColor = Color.Brown;
            rdoBulgogiBurger.Location = new Point(20, 259);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(211, 49);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // pbxHamBurger
            // 
            pbxHamBurger.Image = Properties.Resources.img_HamBurger;
            pbxHamBurger.Location = new Point(234, 65);
            pbxHamBurger.Name = "pbxHamBurger";
            pbxHamBurger.Size = new Size(175, 139);
            pbxHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxHamBurger.TabIndex = 1;
            pbxHamBurger.TabStop = false;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 12F);
            rdoHamBurger.ForeColor = Color.Brown;
            rdoHamBurger.Location = new Point(20, 95);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(147, 49);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += rdoHamBurger_CheckedChanged;
            // 
            // gbxOption
            // 
            gbxOption.Controls.Add(chkSauce);
            gbxOption.Controls.Add(chkCheese);
            gbxOption.Controls.Add(chkCola);
            gbxOption.Controls.Add(chkPotato);
            gbxOption.Font = new Font("맑은 고딕", 12F);
            gbxOption.ForeColor = Color.Maroon;
            gbxOption.Location = new Point(521, 115);
            gbxOption.Name = "gbxOption";
            gbxOption.Size = new Size(301, 276);
            gbxOption.TabIndex = 2;
            gbxOption.TabStop = false;
            gbxOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.FromArgb(128, 64, 0);
            chkSauce.Location = new Point(19, 198);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(191, 49);
            chkSauce.TabIndex = 3;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.FromArgb(128, 64, 0);
            chkCheese.Location = new Point(19, 148);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(191, 49);
            chkCheese.TabIndex = 2;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.FromArgb(128, 64, 0);
            chkCola.Location = new Point(19, 98);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(116, 49);
            chkCola.TabIndex = 1;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkCola_CheckedChanged;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.FromArgb(128, 64, 0);
            chkPotato.Location = new Point(19, 48);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(180, 49);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkPotato_CheckedChanged;
            // 
            // gbxOrder
            // 
            gbxOrder.Controls.Add(lblTotalCost);
            gbxOrder.Controls.Add(lstOrder);
            gbxOrder.Font = new Font("맑은 고딕", 12F);
            gbxOrder.ForeColor = Color.Maroon;
            gbxOrder.Location = new Point(883, 115);
            gbxOrder.Name = "gbxOrder";
            gbxOrder.Size = new Size(428, 368);
            gbxOrder.TabIndex = 3;
            gbxOrder.TabStop = false;
            gbxOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalCost.Location = new Point(18, 310);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(206, 45);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(18, 48);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(390, 229);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(0, 192, 0);
            btnOrder.Font = new Font("맑은 고딕", 13F);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(883, 528);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(224, 80);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.FromArgb(192, 0, 0);
            btnInit.Font = new Font("맑은 고딕", 13F);
            btnInit.ForeColor = Color.White;
            btnInit.Location = new Point(1130, 528);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(181, 80);
            btnInit.TabIndex = 5;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            btnInit.KeyDown += btnInit_KeyDown;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(894, 487);
            lblError.Name = "lblError";
            lblError.Size = new Size(214, 32);
            lblError.TabIndex = 6;
            lblError.Text = "메뉴를 선택하세요";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 730);
            Controls.Add(lblError);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(gbxOrder);
            Controls.Add(gbxOption);
            Controls.Add(gbxMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            gbxMenu.ResumeLayout(false);
            gbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHamBurger).EndInit();
            gbxOption.ResumeLayout(false);
            gbxOption.PerformLayout();
            gbxOrder.ResumeLayout(false);
            gbxOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbxMenu;
        private RadioButton rdoHamBurger;
        private GroupBox gbxOption;
        private GroupBox gbxOrder;
        private PictureBox pbxChickenBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox pbxBulgogiBurger;
        private RadioButton rdoBulgogiBurger;
        private PictureBox pbxHamBurger;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnInit;
        private Label lblError;
    }
}
