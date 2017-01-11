using appbar.AppModel;
using DevExpress.XtraEditors;

namespace appbar
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            appBar1.flyoutPanel1.OwnerControl = panelControl1;

            appBar1.AddItem(new AppBarItem() { Name = "card1", Caption = "card1", Image = Properties.Resources.aballoons, Decription = "full description" });
            appBar1.AddItem(new AppBarItem() { Name = "card2", Caption = "card2", Image = Properties.Resources.acannon });
            appBar1.AddItem(new AppBarItem() { Name = "card3", Caption = "card3", Image = Properties.Resources.acircus_monkey });
            appBar1.AddItem(new AppBarItem() { Name = "card4", Caption = "card4", Image = Properties.Resources.aclown_with_hat });
            appBar1.AddItem(new AppBarItem() { Name = "card5", Caption = "card5", Image = Properties.Resources.afireworks });
            appBar1.AddItem(new AppBarItem() { Name = "card6", Caption = "card6", Image = Properties.Resources.aferris_wheel });

        }
    }
}
