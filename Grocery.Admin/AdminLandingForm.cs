using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery.Admin
{
    public partial class Frm_AdminLanding : Form
    {
        private int childFormNumber = 0;

        public Frm_AdminLanding()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

 

        private void StripLeftMenu_Main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(StripLeftMenu_Master.Selected==true)
            {
                 Panel_ReportMenu_Container.Hide();
                Panel_TransactionMenuContainer.Hide(); Panel_VatMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
                Panel_AccountsMenu_Container.Hide();
                Panel_MasterMenuContainer.Show();
            }
            else if(StripLeftMenu_Transaction.Selected == true)
            {
                Panel_MasterMenuContainer.Hide(); Panel_ReportMenu_Container.Hide(); Panel_AccountsMenu_Container.Hide();
                
                Panel_VatMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
                Panel_TransactionMenuContainer.Show();
            }
            else if (StripLeftMenu_Account.Selected == true)
            {
                Panel_MasterMenuContainer.Hide();
                Panel_TransactionMenuContainer.Hide();
                Panel_ReportMenu_Container.Hide(); Panel_AccountsMenu_Container.Hide();
                Panel_VatMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
                Panel_AccountsMenu_Container.Show();
            }
            else if (StripLeftMenu_Reports.Selected == true)
            {
                Panel_MasterMenuContainer.Hide();
                Panel_TransactionMenuContainer.Hide(); Panel_AccountsMenu_Container.Hide();
                Panel_VatMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
                Panel_ReportMenu_Container.Show();
            }
            else if (StripLeftMenu_VAT_TAX.Selected == true)
            {
                Panel_MasterMenuContainer.Hide();
                Panel_TransactionMenuContainer.Hide(); Panel_ReportMenu_Container.Hide(); Panel_AccountsMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
                Panel_VatMenu_Container.Show();
            }
            else if (StripLeftMenu_HrModules.Selected == true)
            {
                Panel_MasterMenuContainer.Hide();
                Panel_TransactionMenuContainer.Hide(); Panel_ReportMenu_Container.Hide(); Panel_AccountsMenu_Container.Hide(); Panel_VatMenu_Container.Hide();
                Panel_HrMenu_Container.Show();
            }

        }

        private void Frm_AdminLanding_Load(object sender, EventArgs e)
        {
            StripLeftMenu_Master.Checked = true;
            Panel_TransactionMenuContainer.Hide(); Panel_ReportMenu_Container.Hide();
            Panel_AccountsMenu_Container.Hide(); 
            Panel_VatMenu_Container.Hide(); Panel_HrMenu_Container.Hide();
        }

        private void BtnMaster_ItemBrands_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_BrandMaster ObjMDIChild_frm_Master_ItemBrand = new Master.Frm_Master_BrandMaster();
            ObjMDIChild_frm_Master_ItemBrand.Show();
        }

        private void BtnTransactions_LPO_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_LPO ObjMDIChild_frm_Transactions_LPO = new Transactions.frm_Transactions_LPO();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_LPO.Show();
        }

       

        private void BtnTransactions_PurchaseReturn_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_PurchaseReturn frm_Transactions_PurchaseReturn = new Transactions.frm_Transactions_PurchaseReturn();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            frm_Transactions_PurchaseReturn.Show();
        }

        private void BtnTransactions_CustomerPriceList_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_CustomerPriceList ObjMDIChild_frm_Transactions_CustomerPriceList = new Transactions.frm_Transactions_CustomerPriceList();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_CustomerPriceList.Show();
        }

        private void BtnTransactions_GoodsReceiptVoucher_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_GoodsReceiptsVoucher ObjMDIChild_frm_Transactions_GoodsReceiptsVoucher = new Transactions.frm_Transactions_GoodsReceiptsVoucher();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_GoodsReceiptsVoucher.Show();
        }

        private void BtnTransactions_ProgressingInvoice_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_ProgressingInvoice ObjMDIChild_frm_Transactions_ProgressingInvoice = new Transactions.frm_Transactions_ProgressingInvoice();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_ProgressingInvoice.Show();
        }

        private void BtnTransactions_Quotation_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_Quatation ObjMDIChild_frm_Transactions_Quatation = new Transactions.frm_Transactions_Quatation();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_Quatation.Show();
        }

        private void BtnTransactions_Purchase_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transaction_Purchase ObjMDIChild_frm_Transactions_Purchase = new Transactions.frm_Transaction_Purchase();
            //ObjMDIChild_frm_Master_ItemBranch.MdiParent = this;
            ObjMDIChild_frm_Transactions_Purchase.Show();
        }

        private void btnMaster_StockLocation_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_StockLocation ObjMDIChild_Frm_Master_StockLocation = new Master.Frm_Master_StockLocation();
            ObjMDIChild_Frm_Master_StockLocation.Show();
        }

        private void btnMaster_CreditCard_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_CreditCard ObjMDIChild_Frm_Master_CreditCard = new Master.Frm_Master_CreditCard();
            ObjMDIChild_Frm_Master_CreditCard.Show();
        }

        private void btnMaster_Currency_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_CurrencyMaster ObjMDIChild_Frm_Master_CurrencyMaster = new Master.Frm_Master_CurrencyMaster();
            ObjMDIChild_Frm_Master_CurrencyMaster.Show();
        }

        private void btnMaster_Warehouse_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_WarehouseMaster ObjMDIChild_Frm_Master_WarehouseMaster = new Master.Frm_Master_WarehouseMaster();
            ObjMDIChild_Frm_Master_WarehouseMaster.Show();
        }

        private void btnMaster_Customers_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_CustomerDetailsMaster ObjMDIChild_Frm_Master_CustomerDetailsMaster = new Master.Frm_Master_CustomerDetailsMaster();
            ObjMDIChild_Frm_Master_CustomerDetailsMaster.Show();
        }

        private void btnMaster_UOM_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_UnitOfMeasurementMaster ObjMDIChild_Frm_Master_UnitOfMeasurementMaster = new Master.Frm_Master_UnitOfMeasurementMaster();
            ObjMDIChild_Frm_Master_UnitOfMeasurementMaster.Show();
        }

        private void BtnMaster_Supplier_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_SupplierDetailsMaster ObjMDIChild_Frm_Master_SupplierDetailsMaster = new Master.Frm_Master_SupplierDetailsMaster();
            ObjMDIChild_Frm_Master_SupplierDetailsMaster.Show();

        }

        private void BtnMaster_StaffEmployee_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_StaffRegisterMaster ObjMDIChild_Frm_Master_SupplierDetailsMaster = new Master.Frm_Master_StaffRegisterMaster();
            ObjMDIChild_Frm_Master_SupplierDetailsMaster.Show();
        }

        private void BtnMaster_CustomerSupplierGrouping_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_PartyGrouping ObjMDIChild_Frm_Master_PartyGrouping = new Master.Frm_Master_PartyGrouping();
            ObjMDIChild_Frm_Master_PartyGrouping.Show();
        }

        private void BtnMaster_Department_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_Department ObjMDIChild_Frm_Master_Department = new Master.Frm_Master_Department();
            ObjMDIChild_Frm_Master_Department.Show();
        }

        private void BtnMaster_Category_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ItemCategoriesMaster ObjMDIChild_Frm_Master_ItemCategoriesMaster = new Master.Frm_Master_ItemCategoriesMaster();
            ObjMDIChild_Frm_Master_ItemCategoriesMaster.Show();
        }

      

        private void BtnMaster_SubCategory_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ItemSubCategoriesMaster ObjMDIChild_Frm_Master_ItemSubCategoriesMaster = new Master.Frm_Master_ItemSubCategoriesMaster();
            ObjMDIChild_Frm_Master_ItemSubCategoriesMaster.Show();
        }

        private void BtnMaster_Item_Product_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ItemMaster ObjMDIChild_Frm_Master_ItemMaster = new Master.Frm_Master_ItemMaster();
            ObjMDIChild_Frm_Master_ItemMaster.Show();
        }

        private void BtnMaster_ItemSearch_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ItemListingMaster ObjMDIChild_Frm_Master_ItemListingMaster = new Master.Frm_Master_ItemListingMaster();
            ObjMDIChild_Frm_Master_ItemListingMaster.Show();
        }

        private void BtnMaster_ItemModel_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ItemModelMaster ObjMDIChild_Frm_Master_ItemModelMaster = new Master.Frm_Master_ItemModelMaster();
            ObjMDIChild_Frm_Master_ItemModelMaster.Show();
        }

        private void BtnMaster_Product_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_ProductMaster ObjMDIChild_Frm_Master_ProductMaster = new Master.Frm_Master_ProductMaster();
            ObjMDIChild_Frm_Master_ProductMaster.Show();
        }

        private void BtnMaster_BarcodePrinting_Click(object sender, EventArgs e)
        {
            Master.Frm_Master_BarcodeMaster ObjMDIChild_Frm_Master_BarcodeMaster = new Master.Frm_Master_BarcodeMaster();
            ObjMDIChild_Frm_Master_BarcodeMaster.Show();
        }

        private void BtnMaster_PointRegistration_Click(object sender, EventArgs e)
        {

        }

        private void BtnTransactions_CustomerInvoiceSales_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_CustomerInvoice_Sales ObjMDIChild_frm_Transactions_CustomerInvoice_Sales = new Transactions.frm_Transactions_CustomerInvoice_Sales();
            ObjMDIChild_frm_Transactions_CustomerInvoice_Sales.Show();
        }

        private void BtnTransactions_SalesReturn_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_SalesReturn ObjMDIChild_frm_Transactions_SalesReturn = new Transactions.frm_Transactions_SalesReturn();
            ObjMDIChild_frm_Transactions_SalesReturn.Show();
        }

        private void BtnTransactions_SupplierPriceList_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_SupplierPriceList ObjMDIChild_frm_Transactions_SupplierPriceList = new Transactions.frm_Transactions_SupplierPriceList();
            ObjMDIChild_frm_Transactions_SupplierPriceList.Show();
        }

        private void BtnTransactions_ProformaInvoice_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_PerformaInvoice ObjMDIChild_frm_Transactions_PerformaInvoice = new Transactions.frm_Transactions_PerformaInvoice();
            ObjMDIChild_frm_Transactions_PerformaInvoice.Show();
        }

        private void BtnTransactions_SalesOrderBooking_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_SalesOrderBooking ObjMDIChild_frm_Transactions_SalesOrderBooking = new Transactions.frm_Transactions_SalesOrderBooking();
            ObjMDIChild_frm_Transactions_SalesOrderBooking.Show();
        }

        private void BtnTransactions_ItemIssue_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_ItemIssue ObjMDIChild_frm_Transactions_ItemIssue = new Transactions.frm_Transactions_ItemIssue();
            ObjMDIChild_frm_Transactions_ItemIssue.Show();
        }

        private void BtnTransactions_WastageDisposal_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_WastageDisposal ObjMDIChild_frm_Transactions_WastageDisposal = new Transactions.frm_Transactions_WastageDisposal();
            ObjMDIChild_frm_Transactions_WastageDisposal.Show();
        }

        private void BtnTransactions_OfferCreation_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_OfferCreation ObjMDIChild_frm_Transactions_OfferCreation = new Transactions.frm_Transactions_OfferCreation();
            ObjMDIChild_frm_Transactions_OfferCreation.Show();
        }

        private void BtnTransactions_TransApproval_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_TransApproval ObjMDIChild_frm_Transactions_TransApproval = new Transactions.frm_Transactions_TransApproval();
            ObjMDIChild_frm_Transactions_TransApproval.Show();
        }

        private void BtnTransactions_CustomerProjects_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_CustomerProjects ObjMDIChild_frm_Transactions_CustomerProjects = new Transactions.frm_Transactions_CustomerProjects();
            ObjMDIChild_frm_Transactions_CustomerProjects.Show();
        }

        private void BtnTransactions_WorkOrder_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_WorkOrder ObjMDIChild_frm_Transactions_WorkOrder = new Transactions.frm_Transactions_WorkOrder();
            ObjMDIChild_frm_Transactions_WorkOrder.Show();
        }

        private void BtnTransactions_ItemTransfer_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_ItemTransfer ObjMDIChild_frm_Transactions_ItemTransfer = new Transactions.frm_Transactions_ItemTransfer();
            ObjMDIChild_frm_Transactions_ItemTransfer.Show();
        }

        private void BtnTransactions_ItemPack_N_UnpackSales_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_ItemPack_Unpack_Sales ObjMDIChild_frm_Transactions_ItemPack_Unpack_Sales = 
                new Transactions.frm_Transactions_ItemPack_Unpack_Sales();
            ObjMDIChild_frm_Transactions_ItemPack_Unpack_Sales.Show();
        }

        private void BtnTransactions_DeliveryNote_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_DeliveryNote ObjMDIChild_frm_Transactions_DeliveryNote =
               new Transactions.frm_Transactions_DeliveryNote();
            ObjMDIChild_frm_Transactions_DeliveryNote.Show();
        }

        private void BtnTransactions_DeliveryNoteSPL_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_DeliveryNoteSpl ObjMDIChild_frm_Transactions_DeliveryNoteSpl =
                 new Transactions.frm_Transactions_DeliveryNoteSpl();
            ObjMDIChild_frm_Transactions_DeliveryNoteSpl.Show();

        }

        private void BtnTransactions_ServiceOrder_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_ServiceOrder ObjMDIChild_frm_Transactions_ServiceOrder =
                 new Transactions.frm_Transactions_ServiceOrder();
            ObjMDIChild_frm_Transactions_ServiceOrder.Show();
        }

        private void BtnTransactions_StockTransfer_Branches_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_StockTransfer_Branches ObjMDIChild_frm_Transactions_StockTransfer_Branches =
                new Transactions.frm_Transactions_StockTransfer_Branches();
            ObjMDIChild_frm_Transactions_StockTransfer_Branches.Show();
        }

        private void BtnTransactions_WarrantySlip_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_WarratySlip ObjMDIChild_frm_Transactions_WarratySlip =
                new Transactions.frm_Transactions_WarratySlip();
            ObjMDIChild_frm_Transactions_WarratySlip.Show();
        }

        private void BtnTransaction_FocOfferCreation_Click(object sender, EventArgs e)
        {
            Transactions.frm_Transactions_FocOfferCreation ObjMDIChild_frm_Transactions_FocOfferCreation =
               new Transactions.frm_Transactions_FocOfferCreation();
            ObjMDIChild_frm_Transactions_FocOfferCreation.Show();
        }
    }
}
