using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class FrmYetkili : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmYetkili()
        {
            InitializeComponent();
        }
        FrmYeniOtel fyo;
        private void btnYeniKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fyo = new FrmYeniOtel();
            fyo.MdiParent = this;
            fyo.Show();
        }
        FrmOtelGuncelleme fog;
        private void btnGuncellemeSilme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fog = new FrmOtelGuncelleme();
            fog.MdiParent = this;
            fog.Show();
        }
        FrmYeniPersonel fyp;
        private void btnYeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fyp = new FrmYeniPersonel();
            fyp.MdiParent = this;
            fyp.Show();
        }
        FrmPersonelGuncelleme fpg;
        private void btnPersonelGuncelleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fpg = new FrmPersonelGuncelleme();
            fpg.MdiParent = this;
            fpg.Show();

        }
    }
}
