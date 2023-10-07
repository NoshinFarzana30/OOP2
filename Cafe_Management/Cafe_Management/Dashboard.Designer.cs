
namespace Cafe_Management
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveGuest = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuestInformation = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse10 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse11 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_ViewOrders1 = new Cafe_Management.AllUserControls.UC_ViewOrders();
            this.uC_RemoveGuest1 = new Cafe_Management.AllUserControls.UC_RemoveGuest();
            this.uC_GuestInformation1 = new Cafe_Management.AllUserControls.UC_GuestInformation();
            this.uC_RemoveItem1 = new Cafe_Management.AllUserControls.UC_RemoveItem();
            this.uC_UpdateItems1 = new Cafe_Management.AllUserControls.UC_UpdateItems();
            this.uC_PlaceOrder1 = new Cafe_Management.AllUserControls.UC_PlaceOrder();
            this.uC_AddItems1 = new Cafe_Management.AllUserControls.UC_AddItems();
            this.uC_Welcome1 = new Cafe_Management.AllUserControls.UC_Welcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btnViewOrders);
            this.panel1.Controls.Add(this.btnRemoveGuest);
            this.panel1.Controls.Add(this.btnGuestInformation);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 763);
            this.panel1.TabIndex = 0;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BorderRadius = 20;
            this.btnViewOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewOrders.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewOrders.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewOrders.CheckedState.Parent = this.btnViewOrders;
            this.btnViewOrders.CustomImages.Parent = this.btnViewOrders;
            this.guna2Transition1.SetDecoration(this.btnViewOrders, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnViewOrders.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.HoverState.Parent = this.btnViewOrders;
            this.btnViewOrders.Location = new System.Drawing.Point(21, 372);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.ShadowDecoration.Parent = this.btnViewOrders;
            this.btnViewOrders.Size = new System.Drawing.Size(245, 63);
            this.btnViewOrders.TabIndex = 8;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.BorderRadius = 20;
            this.btnRemoveGuest.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemoveGuest.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemoveGuest.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemoveGuest.CheckedState.Parent = this.btnRemoveGuest;
            this.btnRemoveGuest.CustomImages.Parent = this.btnRemoveGuest;
            this.guna2Transition1.SetDecoration(this.btnRemoveGuest, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveGuest.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemoveGuest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGuest.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGuest.HoverState.Parent = this.btnRemoveGuest;
            this.btnRemoveGuest.Location = new System.Drawing.Point(21, 537);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.ShadowDecoration.Parent = this.btnRemoveGuest;
            this.btnRemoveGuest.Size = new System.Drawing.Size(245, 63);
            this.btnRemoveGuest.TabIndex = 7;
            this.btnRemoveGuest.Text = "Remove Guest";
            this.btnRemoveGuest.Click += new System.EventHandler(this.btnRemoveGuest_Click);
            // 
            // btnGuestInformation
            // 
            this.btnGuestInformation.BorderRadius = 20;
            this.btnGuestInformation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGuestInformation.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGuestInformation.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnGuestInformation.CheckedState.Parent = this.btnGuestInformation;
            this.btnGuestInformation.CustomImages.Parent = this.btnGuestInformation;
            this.guna2Transition1.SetDecoration(this.btnGuestInformation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnGuestInformation.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuestInformation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestInformation.ForeColor = System.Drawing.Color.White;
            this.btnGuestInformation.HoverState.Parent = this.btnGuestInformation;
            this.btnGuestInformation.Location = new System.Drawing.Point(21, 454);
            this.btnGuestInformation.Name = "btnGuestInformation";
            this.btnGuestInformation.ShadowDecoration.Parent = this.btnGuestInformation;
            this.btnGuestInformation.Size = new System.Drawing.Size(245, 63);
            this.btnGuestInformation.TabIndex = 6;
            this.btnGuestInformation.Text = "Guest Information";
            this.btnGuestInformation.Click += new System.EventHandler(this.btnGuestInformation_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.LinkColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(87, 639);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 26);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(61, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.guna2Transition1.SetDecoration(this.btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemove.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(21, 294);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(245, 63);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(21, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(245, 63);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Items";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BorderRadius = 20;
            this.btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.CheckedState.Parent = this.btnAddItems;
            this.btnAddItems.CustomImages.Parent = this.btnAddItems;
            this.guna2Transition1.SetDecoration(this.btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddItems.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.HoverState.Parent = this.btnAddItems;
            this.btnAddItems.Location = new System.Drawing.Point(21, 130);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.ShadowDecoration.Parent = this.btnAddItems;
            this.btnAddItems.Size = new System.Drawing.Size(245, 63);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 20;
            this.btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(21, 61);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(245, 63);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_ViewOrders1);
            this.panel2.Controls.Add(this.uC_RemoveGuest1);
            this.panel2.Controls.Add(this.uC_GuestInformation1);
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(323, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 776);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 30;
            this.guna2Elipse8.TargetControl = this.panel2;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.BorderRadius = 30;
            this.guna2Elipse9.TargetControl = this.panel2;
            // 
            // guna2Elipse10
            // 
            this.guna2Elipse10.BorderRadius = 30;
            this.guna2Elipse10.TargetControl = this.panel2;
            // 
            // guna2Elipse11
            // 
            this.guna2Elipse11.BorderRadius = 30;
            this.guna2Elipse11.TargetControl = this.panel2;
            // 
            // uC_ViewOrders1
            // 
            this.uC_ViewOrders1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_ViewOrders1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_ViewOrders1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewOrders1.Name = "uC_ViewOrders1";
            this.uC_ViewOrders1.Size = new System.Drawing.Size(938, 801);
            this.uC_ViewOrders1.TabIndex = 7;
            // 
            // uC_RemoveGuest1
            // 
            this.uC_RemoveGuest1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveGuest1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveGuest1.Location = new System.Drawing.Point(-3, 0);
            this.uC_RemoveGuest1.Name = "uC_RemoveGuest1";
            this.uC_RemoveGuest1.Size = new System.Drawing.Size(948, 776);
            this.uC_RemoveGuest1.TabIndex = 6;
            // 
            // uC_GuestInformation1
            // 
            this.uC_GuestInformation1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_GuestInformation1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_GuestInformation1.Location = new System.Drawing.Point(0, 0);
            this.uC_GuestInformation1.Name = "uC_GuestInformation1";
            this.uC_GuestInformation1.Size = new System.Drawing.Size(938, 763);
            this.uC_GuestInformation1.TabIndex = 5;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(3, 3);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(938, 681);
            this.uC_RemoveItem1.TabIndex = 4;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(945, 787);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(945, 763);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guna2Transition1.SetDecoration(this.uC_AddItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItems1.Location = new System.Drawing.Point(-52, -11);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(1083, 760);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(-39, -39);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(1051, 774);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1276, 814);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
        private Guna.UI2.WinForms.Guna2Button btnGuestInformation;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private AllUserControls.UC_GuestInformation uC_GuestInformation1;
        private Guna.UI2.WinForms.Guna2Button btnRemoveGuest;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private AllUserControls.UC_RemoveGuest uC_RemoveGuest1;
        private Guna.UI2.WinForms.Guna2Button btnViewOrders;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse10;
        private AllUserControls.UC_ViewOrders uC_ViewOrders1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse11;
    }
}