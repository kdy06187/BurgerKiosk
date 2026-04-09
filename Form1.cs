namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                //MessageBox.Show("메뉴를선택하세요.");
                lblError.Visible = true;
                return;
            }

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }


            lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            totalCost = 0;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총금액: 0원";
            lblError.Visible = false;
        }

        private void btnOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOrder_Click(sender, e);
            }
        }

        
    }
}
