﻿using GxModelViewer_WinFormsExt;

namespace GxModelViewer
{
    partial class ModelViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelViewer));
            this.ctxMenuModelOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemResetViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemShowTextures = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripActions = new System.Windows.Forms.ToolStrip();
            this.lsLblGame = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbGame = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLoadTpl = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveTpl = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveTplAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLoadGma = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveGma = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveGmaAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnImportObjMtl = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExportObjMtl = new System.Windows.Forms.ToolStripButton();
            this.tabControlModelsTextures = new System.Windows.Forms.TabControl();
            this.tabPageModels = new System.Windows.Forms.TabPage();
            this.tabPageMaterials = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.defineNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineNewFromTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlagsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMaterialDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMaterialProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaterialFlagsText = new System.Windows.Forms.Label();
            this.lblMaterialTextureIndexText = new System.Windows.Forms.Label();
            this.lblMaterialUnk6Text = new System.Windows.Forms.Label();
            this.lblMaterialAnisotropyLevelText = new System.Windows.Forms.Label();
            this.lblMaterialUnkCText = new System.Windows.Forms.Label();
            this.lblMaterialUnk10Text = new System.Windows.Forms.Label();
            this.lblMaterialFlags = new System.Windows.Forms.Label();
            this.lblMaterialTextureIndex = new System.Windows.Forms.Label();
            this.lblMaterialUnk6 = new System.Windows.Forms.Label();
            this.lblMaterialAnisotropyLevel = new System.Windows.Forms.Label();
            this.lblMaterialUnkC = new System.Windows.Forms.Label();
            this.lblMaterialUnk10 = new System.Windows.Forms.Label();
            this.tabPageTextures = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeTextures = new System.Windows.Forms.TreeView();
            this.textureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.defineNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletenoMaterialAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUnusedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpTextureDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTextureProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextureDimensionsText = new System.Windows.Forms.Label();
            this.btnExportTextureLevel = new System.Windows.Forms.Button();
            this.btnImportTextureLevel = new System.Windows.Forms.Button();
            this.lblTextureDimensions = new System.Windows.Forms.Label();
            this.lblTextureFormatText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTextureFormat = new System.Windows.Forms.Label();
            this.lblTextureUsedBy = new System.Windows.Forms.Label();
            this.gmaContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importGMATPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsGMATPLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmaExportTolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gmaImporttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPreserveFLagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdLoadGma = new System.Windows.Forms.OpenFileDialog();
            this.ofdLoadTpl = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveTpl = new System.Windows.Forms.SaveFileDialog();
            this.ofdTextureImportPath = new System.Windows.Forms.OpenFileDialog();
            this.sfdTextureExportPath = new System.Windows.Forms.SaveFileDialog();
            this.sfdSaveGma = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoadObj = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numMipmapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mipmapInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showValuesAsHexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorForTextureViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meshMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editFlagsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdModelExportPath = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolTipTextureUsedBy = new System.Windows.Forms.ToolTip(this.components);
            this.texViewerColorDialog = new System.Windows.Forms.ColorDialog();
            this.regenerateMipmapsForSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regenerateMipmapsForAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerModels = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelModelSelect = new System.Windows.Forms.TableLayoutPanel();
            this.btnModelHideAll = new System.Windows.Forms.Button();
            this.btnModelShowLayer1 = new System.Windows.Forms.Button();
            this.btnModelShowLayer2 = new System.Windows.Forms.Button();
            this.btnModelShowAll = new System.Windows.Forms.Button();
            this.treeModel = new GxModelViewer_WinFormsExt.TreeViewAutoPartialCheckBox();
            this.tlpMaterialMeshDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tlpModelDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.lblModelSectionFlagsText = new System.Windows.Forms.Label();
            this.lblModelCenterText = new System.Windows.Forms.Label();
            this.lblModelRadiusText = new System.Windows.Forms.Label();
            this.lblModelTransformMatrixDefaultReferencesText = new System.Windows.Forms.Label();
            this.lblModelNumTransformMatricesText = new System.Windows.Forms.Label();
            this.lblModelSectionFlags = new System.Windows.Forms.Label();
            this.lblModelCenter = new System.Windows.Forms.Label();
            this.lblModelRadius = new System.Windows.Forms.Label();
            this.lblModelTransformMatrixDefaultReferences = new System.Windows.Forms.Label();
            this.lblModelNumTransformMatrices = new System.Windows.Forms.Label();
            this.glControlModel = new OpenTK.GLControl();
            this.tlpMeshDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.lblMeshUnk12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMeshRenderFlagsText = new System.Windows.Forms.Label();
            this.lblMeshUnk4Text = new System.Windows.Forms.Label();
            this.lblMeshUnk8Text = new System.Windows.Forms.Label();
            this.lblMeshUnkCText = new System.Windows.Forms.Label();
            this.lblMeshUnk10Text = new System.Windows.Forms.Label();
            this.lblMeshUnk14Text = new System.Windows.Forms.Label();
            this.lblMeshPrimaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshSecondaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshTertiaryMaterialIdxText = new System.Windows.Forms.Label();
            this.lblMeshTransformMatrixSpecificReferencesText = new System.Windows.Forms.Label();
            this.lblMeshCenterText = new System.Windows.Forms.Label();
            this.lblMeshUnk3CText = new System.Windows.Forms.Label();
            this.lblMeshUnk40Text = new System.Windows.Forms.Label();
            this.lblMeshUnk40 = new System.Windows.Forms.Label();
            this.lblMeshUnk3C = new System.Windows.Forms.Label();
            this.lblMeshCenter = new System.Windows.Forms.Label();
            this.lblMeshTransformMatrixSpecificReferences = new System.Windows.Forms.Label();
            this.lblMeshTertiaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshSecondaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshPrimaryMaterialIdx = new System.Windows.Forms.Label();
            this.lblMeshUnk14 = new System.Windows.Forms.Label();
            this.lblMeshUnk10 = new System.Windows.Forms.Label();
            this.lblMeshUnkC = new System.Windows.Forms.Label();
            this.lblMeshUnk8 = new System.Windows.Forms.Label();
            this.lblMeshUnk4 = new System.Windows.Forms.Label();
            this.lblMeshRenderFlags = new System.Windows.Forms.Label();
            this.treeMaterials = new TreeViewMS.TreeViewMS();
            this.pbMaterialTextureImage = new GxModelViewer_WinFormsExt.PictureBoxDownsizeIfNecessary();
            this.pbTextureImage = new GxModelViewer_WinFormsExt.PictureBoxDownsizeIfNecessary();
            this.changeFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuModelOptions.SuspendLayout();
            this.toolStripActions.SuspendLayout();
            this.tabControlModelsTextures.SuspendLayout();
            this.tabPageModels.SuspendLayout();
            this.tabPageMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.materialMenuStrip.SuspendLayout();
            this.tlpMaterialDisplay.SuspendLayout();
            this.tlpMaterialProperties.SuspendLayout();
            this.tabPageTextures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.textureMenuStrip.SuspendLayout();
            this.tlpTextureDisplay.SuspendLayout();
            this.tlpTextureProperties.SuspendLayout();
            this.gmaContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.meshMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerModels)).BeginInit();
            this.splitContainerModels.Panel1.SuspendLayout();
            this.splitContainerModels.Panel2.SuspendLayout();
            this.splitContainerModels.SuspendLayout();
            this.tableLayoutPanelModelSelect.SuspendLayout();
            this.tlpMaterialMeshDisplay.SuspendLayout();
            this.tlpModelDisplay.SuspendLayout();
            this.tlpMeshDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialTextureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTextureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxMenuModelOptions
            // 
            this.ctxMenuModelOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemResetViewer,
            this.reloadViewerToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItemShowTextures});
            this.ctxMenuModelOptions.Name = "ctxMenuModelOptions";
            this.ctxMenuModelOptions.Size = new System.Drawing.Size(150, 76);
            // 
            // toolStripMenuItemResetViewer
            // 
            this.toolStripMenuItemResetViewer.Name = "toolStripMenuItemResetViewer";
            this.toolStripMenuItemResetViewer.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemResetViewer.Text = "Reset Viewer";
            this.toolStripMenuItemResetViewer.Click += new System.EventHandler(this.toolStripMenuItemResetViewer_Click);
            // 
            // reloadViewerToolStripMenuItem
            // 
            this.reloadViewerToolStripMenuItem.Name = "reloadViewerToolStripMenuItem";
            this.reloadViewerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.reloadViewerToolStripMenuItem.Text = "Reload Viewer";
            this.reloadViewerToolStripMenuItem.Click += new System.EventHandler(this.reloadViewerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(146, 6);
            // 
            // toolStripMenuItemShowTextures
            // 
            this.toolStripMenuItemShowTextures.Checked = true;
            this.toolStripMenuItemShowTextures.CheckOnClick = true;
            this.toolStripMenuItemShowTextures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowTextures.Name = "toolStripMenuItemShowTextures";
            this.toolStripMenuItemShowTextures.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemShowTextures.Text = "Show Textures";
            this.toolStripMenuItemShowTextures.Click += new System.EventHandler(this.toolStripMenuItemShowTextures_Click);
            // 
            // toolStripActions
            // 
            this.toolStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lsLblGame,
            this.tsCmbGame,
            this.toolStripSeparator5,
            this.toolStripSeparator1,
            this.tsBtnLoadTpl,
            this.tsBtnSaveTpl,
            this.tsBtnSaveTplAs,
            this.toolStripSeparator2,
            this.tsBtnLoadGma,
            this.tsBtnSaveGma,
            this.tsBtnSaveGmaAs,
            this.toolStripSeparator3,
            this.tsBtnImportObjMtl,
            this.tsBtnExportObjMtl});
            this.toolStripActions.Location = new System.Drawing.Point(0, 24);
            this.toolStripActions.Name = "toolStripActions";
            this.toolStripActions.Size = new System.Drawing.Size(961, 25);
            this.toolStripActions.TabIndex = 1;
            this.toolStripActions.Text = "toolStrip1";
            // 
            // lsLblGame
            // 
            this.lsLblGame.Name = "lsLblGame";
            this.lsLblGame.Size = new System.Drawing.Size(44, 22);
            this.lsLblGame.Text = "Game: ";
            // 
            // tsCmbGame
            // 
            this.tsCmbGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsCmbGame.DropDownWidth = 121;
            this.tsCmbGame.Name = "tsCmbGame";
            this.tsCmbGame.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnLoadTpl
            // 
            this.tsBtnLoadTpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnLoadTpl.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLoadTpl.Image")));
            this.tsBtnLoadTpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLoadTpl.Name = "tsBtnLoadTpl";
            this.tsBtnLoadTpl.Size = new System.Drawing.Size(68, 22);
            this.tsBtnLoadTpl.Text = "Load TPL...";
            this.tsBtnLoadTpl.Click += new System.EventHandler(this.tsBtnLoadTpl_Click);
            // 
            // tsBtnSaveTpl
            // 
            this.tsBtnSaveTpl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSaveTpl.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveTpl.Image")));
            this.tsBtnSaveTpl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveTpl.Name = "tsBtnSaveTpl";
            this.tsBtnSaveTpl.Size = new System.Drawing.Size(57, 22);
            this.tsBtnSaveTpl.Text = "Save TPL";
            this.tsBtnSaveTpl.Click += new System.EventHandler(this.tsBtnSaveTpl_Click);
            // 
            // tsBtnSaveTplAs
            // 
            this.tsBtnSaveTplAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSaveTplAs.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveTplAs.Image")));
            this.tsBtnSaveTplAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveTplAs.Name = "tsBtnSaveTplAs";
            this.tsBtnSaveTplAs.Size = new System.Drawing.Size(82, 22);
            this.tsBtnSaveTplAs.Text = "Save TPL As...";
            this.tsBtnSaveTplAs.Click += new System.EventHandler(this.tsBtnSaveTplAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnLoadGma
            // 
            this.tsBtnLoadGma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnLoadGma.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLoadGma.Image")));
            this.tsBtnLoadGma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLoadGma.Name = "tsBtnLoadGma";
            this.tsBtnLoadGma.Size = new System.Drawing.Size(76, 22);
            this.tsBtnLoadGma.Text = "Load GMA...";
            this.tsBtnLoadGma.ToolTipText = "Load GMA";
            this.tsBtnLoadGma.Click += new System.EventHandler(this.tsBtnLoadGma_Click);
            // 
            // tsBtnSaveGma
            // 
            this.tsBtnSaveGma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSaveGma.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveGma.Image")));
            this.tsBtnSaveGma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveGma.Name = "tsBtnSaveGma";
            this.tsBtnSaveGma.Size = new System.Drawing.Size(65, 22);
            this.tsBtnSaveGma.Text = "Save GMA";
            this.tsBtnSaveGma.Click += new System.EventHandler(this.tsBtnSaveGma_Click);
            // 
            // tsBtnSaveGmaAs
            // 
            this.tsBtnSaveGmaAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnSaveGmaAs.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveGmaAs.Image")));
            this.tsBtnSaveGmaAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveGmaAs.Name = "tsBtnSaveGmaAs";
            this.tsBtnSaveGmaAs.Size = new System.Drawing.Size(90, 22);
            this.tsBtnSaveGmaAs.Text = "Save GMA As...";
            this.tsBtnSaveGmaAs.Click += new System.EventHandler(this.tsBtnSaveGmaAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnImportObjMtl
            // 
            this.tsBtnImportObjMtl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnImportObjMtl.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnImportObjMtl.Image")));
            this.tsBtnImportObjMtl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImportObjMtl.Name = "tsBtnImportObjMtl";
            this.tsBtnImportObjMtl.Size = new System.Drawing.Size(97, 22);
            this.tsBtnImportObjMtl.Text = "Load OBJ/MTL...";
            this.tsBtnImportObjMtl.Click += new System.EventHandler(this.tsBtnImportObjMtl_Click);
            // 
            // tsBtnExportObjMtl
            // 
            this.tsBtnExportObjMtl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnExportObjMtl.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportObjMtl.Image")));
            this.tsBtnExportObjMtl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportObjMtl.Name = "tsBtnExportObjMtl";
            this.tsBtnExportObjMtl.Size = new System.Drawing.Size(109, 22);
            this.tsBtnExportObjMtl.Text = "Save as OBJ/MTL...";
            this.tsBtnExportObjMtl.Click += new System.EventHandler(this.tsBtnExportObjMtl_Click);
            // 
            // tabControlModelsTextures
            // 
            this.tabControlModelsTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlModelsTextures.Controls.Add(this.tabPageModels);
            this.tabControlModelsTextures.Controls.Add(this.tabPageMaterials);
            this.tabControlModelsTextures.Controls.Add(this.tabPageTextures);
            this.tabControlModelsTextures.Location = new System.Drawing.Point(12, 52);
            this.tabControlModelsTextures.Name = "tabControlModelsTextures";
            this.tabControlModelsTextures.SelectedIndex = 0;
            this.tabControlModelsTextures.Size = new System.Drawing.Size(937, 522);
            this.tabControlModelsTextures.TabIndex = 2;
            // 
            // tabPageModels
            // 
            this.tabPageModels.Controls.Add(this.splitContainerModels);
            this.tabPageModels.Location = new System.Drawing.Point(4, 22);
            this.tabPageModels.Name = "tabPageModels";
            this.tabPageModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModels.Size = new System.Drawing.Size(929, 496);
            this.tabPageModels.TabIndex = 0;
            this.tabPageModels.Text = "Models";
            this.tabPageModels.UseVisualStyleBackColor = true;
            // 
            // tabPageMaterials
            // 
            this.tabPageMaterials.Controls.Add(this.splitContainer1);
            this.tabPageMaterials.Location = new System.Drawing.Point(4, 22);
            this.tabPageMaterials.Name = "tabPageMaterials";
            this.tabPageMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaterials.Size = new System.Drawing.Size(929, 496);
            this.tabPageMaterials.TabIndex = 2;
            this.tabPageMaterials.Text = "Materials";
            this.tabPageMaterials.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeMaterials);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlpMaterialDisplay);
            this.splitContainer1.Size = new System.Drawing.Size(923, 490);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // materialMenuStrip
            // 
            this.materialMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineNewToolStripMenuItem,
            this.defineNewFromTextureToolStripMenuItem,
            this.editFlagsToolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.materialMenuStrip.Name = "materialMenuStrip";
            this.materialMenuStrip.Size = new System.Drawing.Size(242, 92);
            this.materialMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.materialMenuStrip_Opening);
            // 
            // defineNewToolStripMenuItem
            // 
            this.defineNewToolStripMenuItem.Name = "defineNewToolStripMenuItem";
            this.defineNewToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.defineNewToolStripMenuItem.Text = "Create New...";
            this.defineNewToolStripMenuItem.Click += new System.EventHandler(this.defineNewToolStripMenuItem_Click);
            // 
            // defineNewFromTextureToolStripMenuItem
            // 
            this.defineNewFromTextureToolStripMenuItem.Name = "defineNewFromTextureToolStripMenuItem";
            this.defineNewFromTextureToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.defineNewFromTextureToolStripMenuItem.Text = "Create New from New Texture...";
            this.defineNewFromTextureToolStripMenuItem.Click += new System.EventHandler(this.defineNewFromTextureToolStripMenuItem_Click);
            // 
            // editFlagsToolStripMenuItem2
            // 
            this.editFlagsToolStripMenuItem2.Name = "editFlagsToolStripMenuItem2";
            this.editFlagsToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.editFlagsToolStripMenuItem2.Text = "Edit Flags...";
            this.editFlagsToolStripMenuItem2.Click += new System.EventHandler(this.editMaterialFlagstoolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tlpMaterialDisplay
            // 
            this.tlpMaterialDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMaterialDisplay.ColumnCount = 1;
            this.tlpMaterialDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterialDisplay.Controls.Add(this.tlpMaterialProperties, 0, 1);
            this.tlpMaterialDisplay.Controls.Add(this.pbMaterialTextureImage, 0, 0);
            this.tlpMaterialDisplay.Location = new System.Drawing.Point(3, 3);
            this.tlpMaterialDisplay.Name = "tlpMaterialDisplay";
            this.tlpMaterialDisplay.RowCount = 3;
            this.tlpMaterialDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterialDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterialDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterialDisplay.Size = new System.Drawing.Size(607, 484);
            this.tlpMaterialDisplay.TabIndex = 1;
            // 
            // tlpMaterialProperties
            // 
            this.tlpMaterialProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMaterialProperties.ColumnCount = 2;
            this.tlpMaterialProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaterialProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialFlagsText, 0, 0);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialTextureIndexText, 0, 1);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnk6Text, 0, 2);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialAnisotropyLevelText, 0, 3);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnkCText, 0, 4);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnk10Text, 0, 5);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialFlags, 1, 0);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialTextureIndex, 1, 1);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnk6, 1, 2);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialAnisotropyLevel, 1, 3);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnkC, 1, 4);
            this.tlpMaterialProperties.Controls.Add(this.lblMaterialUnk10, 1, 5);
            this.tlpMaterialProperties.Location = new System.Drawing.Point(3, 359);
            this.tlpMaterialProperties.Name = "tlpMaterialProperties";
            this.tlpMaterialProperties.RowCount = 6;
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMaterialProperties.Size = new System.Drawing.Size(601, 122);
            this.tlpMaterialProperties.TabIndex = 1;
            // 
            // lblMaterialFlagsText
            // 
            this.lblMaterialFlagsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblMaterialFlagsText.Name = "lblMaterialFlagsText";
            this.lblMaterialFlagsText.Size = new System.Drawing.Size(294, 20);
            this.lblMaterialFlagsText.TabIndex = 0;
            this.lblMaterialFlagsText.Text = "Material Flags (0x00):";
            this.lblMaterialFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialTextureIndexText
            // 
            this.lblMaterialTextureIndexText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialTextureIndexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialTextureIndexText.Location = new System.Drawing.Point(3, 20);
            this.lblMaterialTextureIndexText.Name = "lblMaterialTextureIndexText";
            this.lblMaterialTextureIndexText.Size = new System.Drawing.Size(294, 20);
            this.lblMaterialTextureIndexText.TabIndex = 1;
            this.lblMaterialTextureIndexText.Text = "Texture Index (0x04):";
            this.lblMaterialTextureIndexText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnk6Text
            // 
            this.lblMaterialUnk6Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk6Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnk6Text.Location = new System.Drawing.Point(3, 40);
            this.lblMaterialUnk6Text.Name = "lblMaterialUnk6Text";
            this.lblMaterialUnk6Text.Size = new System.Drawing.Size(294, 20);
            this.lblMaterialUnk6Text.TabIndex = 2;
            this.lblMaterialUnk6Text.Text = "Unknown (0x06):";
            this.lblMaterialUnk6Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialAnisotropyLevelText
            // 
            this.lblMaterialAnisotropyLevelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialAnisotropyLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialAnisotropyLevelText.Location = new System.Drawing.Point(3, 60);
            this.lblMaterialAnisotropyLevelText.Name = "lblMaterialAnisotropyLevelText";
            this.lblMaterialAnisotropyLevelText.Size = new System.Drawing.Size(294, 20);
            this.lblMaterialAnisotropyLevelText.TabIndex = 3;
            this.lblMaterialAnisotropyLevelText.Text = "Anisotropy Level (0x07):";
            this.lblMaterialAnisotropyLevelText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnkCText
            // 
            this.lblMaterialUnkCText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnkCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnkCText.Location = new System.Drawing.Point(3, 80);
            this.lblMaterialUnkCText.Name = "lblMaterialUnkCText";
            this.lblMaterialUnkCText.Size = new System.Drawing.Size(294, 20);
            this.lblMaterialUnkCText.TabIndex = 4;
            this.lblMaterialUnkCText.Text = "Unknown (0x0C):";
            this.lblMaterialUnkCText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialUnk10Text
            // 
            this.lblMaterialUnk10Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk10Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialUnk10Text.Location = new System.Drawing.Point(3, 100);
            this.lblMaterialUnk10Text.Name = "lblMaterialUnk10Text";
            this.lblMaterialUnk10Text.Size = new System.Drawing.Size(294, 22);
            this.lblMaterialUnk10Text.TabIndex = 5;
            this.lblMaterialUnk10Text.Text = "Unknown (0x10):";
            this.lblMaterialUnk10Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialFlags
            // 
            this.lblMaterialFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialFlags.Location = new System.Drawing.Point(303, 0);
            this.lblMaterialFlags.Name = "lblMaterialFlags";
            this.lblMaterialFlags.Size = new System.Drawing.Size(295, 20);
            this.lblMaterialFlags.TabIndex = 6;
            this.lblMaterialFlags.Text = "-";
            // 
            // lblMaterialTextureIndex
            // 
            this.lblMaterialTextureIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialTextureIndex.Location = new System.Drawing.Point(303, 20);
            this.lblMaterialTextureIndex.Name = "lblMaterialTextureIndex";
            this.lblMaterialTextureIndex.Size = new System.Drawing.Size(295, 20);
            this.lblMaterialTextureIndex.TabIndex = 7;
            this.lblMaterialTextureIndex.Text = "-";
            // 
            // lblMaterialUnk6
            // 
            this.lblMaterialUnk6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk6.Location = new System.Drawing.Point(303, 40);
            this.lblMaterialUnk6.Name = "lblMaterialUnk6";
            this.lblMaterialUnk6.Size = new System.Drawing.Size(295, 20);
            this.lblMaterialUnk6.TabIndex = 8;
            this.lblMaterialUnk6.Text = "-";
            // 
            // lblMaterialAnisotropyLevel
            // 
            this.lblMaterialAnisotropyLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialAnisotropyLevel.Location = new System.Drawing.Point(303, 60);
            this.lblMaterialAnisotropyLevel.Name = "lblMaterialAnisotropyLevel";
            this.lblMaterialAnisotropyLevel.Size = new System.Drawing.Size(295, 20);
            this.lblMaterialAnisotropyLevel.TabIndex = 9;
            this.lblMaterialAnisotropyLevel.Text = "-";
            // 
            // lblMaterialUnkC
            // 
            this.lblMaterialUnkC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnkC.Location = new System.Drawing.Point(303, 80);
            this.lblMaterialUnkC.Name = "lblMaterialUnkC";
            this.lblMaterialUnkC.Size = new System.Drawing.Size(295, 20);
            this.lblMaterialUnkC.TabIndex = 10;
            this.lblMaterialUnkC.Text = "-";
            // 
            // lblMaterialUnk10
            // 
            this.lblMaterialUnk10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaterialUnk10.Location = new System.Drawing.Point(303, 100);
            this.lblMaterialUnk10.Name = "lblMaterialUnk10";
            this.lblMaterialUnk10.Size = new System.Drawing.Size(295, 22);
            this.lblMaterialUnk10.TabIndex = 11;
            this.lblMaterialUnk10.Text = "-";
            // 
            // tabPageTextures
            // 
            this.tabPageTextures.Controls.Add(this.splitContainer2);
            this.tabPageTextures.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextures.Name = "tabPageTextures";
            this.tabPageTextures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextures.Size = new System.Drawing.Size(929, 496);
            this.tabPageTextures.TabIndex = 1;
            this.tabPageTextures.Text = "Textures";
            this.tabPageTextures.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeTextures);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tlpTextureDisplay);
            this.splitContainer2.Size = new System.Drawing.Size(923, 490);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeTextures
            // 
            this.treeTextures.ContextMenuStrip = this.textureMenuStrip;
            this.treeTextures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTextures.Location = new System.Drawing.Point(0, 0);
            this.treeTextures.Name = "treeTextures";
            this.treeTextures.Size = new System.Drawing.Size(306, 490);
            this.treeTextures.TabIndex = 0;
            this.treeTextures.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTextures_AfterSelect);
            this.treeTextures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeTextures_MouseDown);
            // 
            // textureMenuStrip
            // 
            this.textureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineNewToolStripMenuItem1,
            this.changeFormatToolStripMenuItem,
            this.regenerateMipmapsForSelectedToolStripMenuItem,
            this.regenerateMipmapsForAllToolStripMenuItem,
            this.removeToolStripMenuItem1,
            this.deletenoMaterialAdjustmentToolStripMenuItem,
            this.removeUnusedToolStripMenuItem});
            this.textureMenuStrip.Name = "textureMenuStrip";
            this.textureMenuStrip.Size = new System.Drawing.Size(252, 180);
            // 
            // defineNewToolStripMenuItem1
            // 
            this.defineNewToolStripMenuItem1.Name = "defineNewToolStripMenuItem1";
            this.defineNewToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.defineNewToolStripMenuItem1.Text = "Import New Texture(s)...";
            this.defineNewToolStripMenuItem1.Click += new System.EventHandler(this.defineNewToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.removeToolStripMenuItem1.Text = "Delete";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // deletenoMaterialAdjustmentToolStripMenuItem
            // 
            this.deletenoMaterialAdjustmentToolStripMenuItem.Name = "deletenoMaterialAdjustmentToolStripMenuItem";
            this.deletenoMaterialAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.deletenoMaterialAdjustmentToolStripMenuItem.Text = "Delete (no material adjustment)";
            this.deletenoMaterialAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.deletenoMaterialAdjustmentToolStripMenuItem_Click);
            // 
            // removeUnusedToolStripMenuItem
            // 
            this.removeUnusedToolStripMenuItem.Name = "removeUnusedToolStripMenuItem";
            this.removeUnusedToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.removeUnusedToolStripMenuItem.Text = "Delete All Unused";
            this.removeUnusedToolStripMenuItem.Click += new System.EventHandler(this.removeUnusedToolStripMenuItem_Click);
            // 
            // tlpTextureDisplay
            // 
            this.tlpTextureDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTextureDisplay.ColumnCount = 1;
            this.tlpTextureDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextureDisplay.Controls.Add(this.tlpTextureProperties, 0, 1);
            this.tlpTextureDisplay.Controls.Add(this.pbTextureImage, 0, 0);
            this.tlpTextureDisplay.Location = new System.Drawing.Point(2, 3);
            this.tlpTextureDisplay.Name = "tlpTextureDisplay";
            this.tlpTextureDisplay.RowCount = 2;
            this.tlpTextureDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextureDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTextureDisplay.Size = new System.Drawing.Size(608, 484);
            this.tlpTextureDisplay.TabIndex = 4;
            // 
            // tlpTextureProperties
            // 
            this.tlpTextureProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTextureProperties.ColumnCount = 2;
            this.tlpTextureProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTextureProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTextureProperties.Controls.Add(this.lblTextureDimensionsText, 0, 0);
            this.tlpTextureProperties.Controls.Add(this.btnExportTextureLevel, 0, 3);
            this.tlpTextureProperties.Controls.Add(this.btnImportTextureLevel, 1, 3);
            this.tlpTextureProperties.Controls.Add(this.lblTextureDimensions, 1, 0);
            this.tlpTextureProperties.Controls.Add(this.lblTextureFormatText, 0, 1);
            this.tlpTextureProperties.Controls.Add(this.label2, 0, 2);
            this.tlpTextureProperties.Controls.Add(this.lblTextureFormat, 1, 1);
            this.tlpTextureProperties.Controls.Add(this.lblTextureUsedBy, 1, 2);
            this.tlpTextureProperties.Location = new System.Drawing.Point(3, 381);
            this.tlpTextureProperties.Name = "tlpTextureProperties";
            this.tlpTextureProperties.RowCount = 4;
            this.tlpTextureProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTextureProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tlpTextureProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpTextureProperties.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTextureProperties.Size = new System.Drawing.Size(602, 100);
            this.tlpTextureProperties.TabIndex = 3;
            // 
            // lblTextureDimensionsText
            // 
            this.lblTextureDimensionsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureDimensionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextureDimensionsText.Location = new System.Drawing.Point(3, 0);
            this.lblTextureDimensionsText.Name = "lblTextureDimensionsText";
            this.lblTextureDimensionsText.Size = new System.Drawing.Size(295, 20);
            this.lblTextureDimensionsText.TabIndex = 0;
            this.lblTextureDimensionsText.Text = "Dimensions:";
            this.lblTextureDimensionsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExportTextureLevel
            // 
            this.btnExportTextureLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportTextureLevel.Location = new System.Drawing.Point(3, 63);
            this.btnExportTextureLevel.Name = "btnExportTextureLevel";
            this.btnExportTextureLevel.Size = new System.Drawing.Size(295, 34);
            this.btnExportTextureLevel.TabIndex = 1;
            this.btnExportTextureLevel.Text = "Export...";
            this.btnExportTextureLevel.UseVisualStyleBackColor = true;
            this.btnExportTextureLevel.Click += new System.EventHandler(this.btnExportTextureLevel_Click);
            // 
            // btnImportTextureLevel
            // 
            this.btnImportTextureLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImportTextureLevel.Location = new System.Drawing.Point(304, 63);
            this.btnImportTextureLevel.Name = "btnImportTextureLevel";
            this.btnImportTextureLevel.Size = new System.Drawing.Size(295, 34);
            this.btnImportTextureLevel.TabIndex = 2;
            this.btnImportTextureLevel.Text = "Import...";
            this.btnImportTextureLevel.UseVisualStyleBackColor = true;
            this.btnImportTextureLevel.Click += new System.EventHandler(this.btnImportTextureLevel_Click);
            // 
            // lblTextureDimensions
            // 
            this.lblTextureDimensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureDimensions.Location = new System.Drawing.Point(304, 0);
            this.lblTextureDimensions.Name = "lblTextureDimensions";
            this.lblTextureDimensions.Size = new System.Drawing.Size(295, 20);
            this.lblTextureDimensions.TabIndex = 1;
            this.lblTextureDimensions.Text = "-";
            // 
            // lblTextureFormatText
            // 
            this.lblTextureFormatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureFormatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextureFormatText.Location = new System.Drawing.Point(3, 20);
            this.lblTextureFormatText.Name = "lblTextureFormatText";
            this.lblTextureFormatText.Size = new System.Drawing.Size(295, 11);
            this.lblTextureFormatText.TabIndex = 2;
            this.lblTextureFormatText.Text = "Format:";
            this.lblTextureFormatText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Used by:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextureFormat
            // 
            this.lblTextureFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextureFormat.Location = new System.Drawing.Point(304, 20);
            this.lblTextureFormat.Name = "lblTextureFormat";
            this.lblTextureFormat.Size = new System.Drawing.Size(295, 11);
            this.lblTextureFormat.TabIndex = 3;
            this.lblTextureFormat.Text = "-";
            // 
            // lblTextureUsedBy
            // 
            this.lblTextureUsedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTextureUsedBy.AutoEllipsis = true;
            this.lblTextureUsedBy.AutoSize = true;
            this.lblTextureUsedBy.Location = new System.Drawing.Point(304, 39);
            this.lblTextureUsedBy.Name = "lblTextureUsedBy";
            this.lblTextureUsedBy.Size = new System.Drawing.Size(10, 13);
            this.lblTextureUsedBy.TabIndex = 5;
            this.lblTextureUsedBy.Text = "-";
            // 
            // gmaContextMenuStrip
            // 
            this.gmaContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importGMATPLToolStripMenuItem,
            this.exportAsGMATPLToolStripMenuItem,
            this.gmaExportTolStripMenuItem,
            this.gmaImporttoolStripMenuItem,
            this.importPreserveFLagsToolStripMenuItem,
            this.translateModelToolStripMenuItem,
            this.duplicateModelToolStripMenuItem,
            this.editFlagsToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.gmaContextMenuStrip.Name = "gmaContextMenuStrip";
            this.gmaContextMenuStrip.Size = new System.Drawing.Size(262, 224);
            // 
            // importGMATPLToolStripMenuItem
            // 
            this.importGMATPLToolStripMenuItem.Name = "importGMATPLToolStripMenuItem";
            this.importGMATPLToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.importGMATPLToolStripMenuItem.Text = "Import GMA/TPL...";
            this.importGMATPLToolStripMenuItem.Click += new System.EventHandler(this.importGMATPLToolStripMenuItem_Click);
            // 
            // exportAsGMATPLToolStripMenuItem
            // 
            this.exportAsGMATPLToolStripMenuItem.Name = "exportAsGMATPLToolStripMenuItem";
            this.exportAsGMATPLToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.exportAsGMATPLToolStripMenuItem.Text = "Export as GMA/TPL...";
            this.exportAsGMATPLToolStripMenuItem.Click += new System.EventHandler(this.exportAsGMATPLToolStripMenuItem_Click);
            // 
            // gmaExportTolStripMenuItem
            // 
            this.gmaExportTolStripMenuItem.Name = "gmaExportTolStripMenuItem";
            this.gmaExportTolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.gmaExportTolStripMenuItem.Text = "Export as OBJ/MTL...";
            this.gmaExportTolStripMenuItem.Click += new System.EventHandler(this.gmaExportTolStripMenuItem_Click);
            // 
            // gmaImporttoolStripMenuItem
            // 
            this.gmaImporttoolStripMenuItem.Name = "gmaImporttoolStripMenuItem";
            this.gmaImporttoolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.gmaImporttoolStripMenuItem.Text = "Replace with OBJ...";
            this.gmaImporttoolStripMenuItem.Click += new System.EventHandler(this.gmaImporttoolStripMenuItem_Click);
            // 
            // importPreserveFLagsToolStripMenuItem
            // 
            this.importPreserveFLagsToolStripMenuItem.Name = "importPreserveFLagsToolStripMenuItem";
            this.importPreserveFLagsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.importPreserveFLagsToolStripMenuItem.Text = "Replace with OBJ...  (Preserve Flags)";
            this.importPreserveFLagsToolStripMenuItem.Click += new System.EventHandler(this.gmaImportPreserveFlagstoolStripMenuItem_Click);
            // 
            // translateModelToolStripMenuItem
            // 
            this.translateModelToolStripMenuItem.Name = "translateModelToolStripMenuItem";
            this.translateModelToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.translateModelToolStripMenuItem.Text = "Translate Model...";
            this.translateModelToolStripMenuItem.Click += new System.EventHandler(this.translateModelToolStripMenuItem_Click);
            // 
            // duplicateModelToolStripMenuItem
            // 
            this.duplicateModelToolStripMenuItem.Name = "duplicateModelToolStripMenuItem";
            this.duplicateModelToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.duplicateModelToolStripMenuItem.Text = "Duplicate Model";
            this.duplicateModelToolStripMenuItem.Click += new System.EventHandler(this.duplicateModelToolStripMenuItem_Click);
            // 
            // editFlagsToolStripMenuItem
            // 
            this.editFlagsToolStripMenuItem.Name = "editFlagsToolStripMenuItem";
            this.editFlagsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.editFlagsToolStripMenuItem.Text = "Edit Flags...";
            this.editFlagsToolStripMenuItem.Click += new System.EventHandler(this.editModelFlagstoolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.removeToolStripMenuItem.Text = "Delete";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ofdLoadGma
            // 
            this.ofdLoadGma.DefaultExt = "gma";
            this.ofdLoadGma.Filter = "GMA Files|*.gma|All Files|*.*";
            this.ofdLoadGma.Title = "Load GMA File...";
            // 
            // ofdLoadTpl
            // 
            this.ofdLoadTpl.DefaultExt = "tpl";
            this.ofdLoadTpl.Filter = "TPL Files|*.tpl|All Files|*.*";
            this.ofdLoadTpl.Title = "Load TPL File...";
            // 
            // sfdSaveTpl
            // 
            this.sfdSaveTpl.DefaultExt = "tpl";
            this.sfdSaveTpl.Filter = "TPL Files|*.tpl|All Files|*.*";
            this.sfdSaveTpl.Title = "Save TPL File...";
            // 
            // ofdTextureImportPath
            // 
            this.ofdTextureImportPath.Filter = "Image files|*.png;*.tiff;*.gif;*.jpg;*.jpeg;*.bmp|All Files|*.*";
            this.ofdTextureImportPath.Title = "Select texture file to import...";
            // 
            // sfdTextureExportPath
            // 
            this.sfdTextureExportPath.DefaultExt = "png";
            this.sfdTextureExportPath.Filter = "Image files|*.png,*.tiff,*.gif,*.jpg,*.jpeg,*.bmp|All Files|*.*";
            this.sfdTextureExportPath.Title = "Select file to export to...";
            // 
            // sfdSaveGma
            // 
            this.sfdSaveGma.DefaultExt = "gma";
            this.sfdSaveGma.Filter = "GMA Files|*.gma|All Files|*.*";
            this.sfdSaveGma.Title = "Save GMA File...";
            // 
            // ofdLoadObj
            // 
            this.ofdLoadObj.DefaultExt = "obj";
            this.ofdLoadObj.Filter = "OBJ Files|*.obj|All Files|*.*";
            this.ofdLoadObj.Title = "Load OBJ File...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numMipmapsToolStripMenuItem,
            this.mipmapInterpolationToolStripMenuItem,
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem,
            this.showValuesAsHexadecimalToolStripMenuItem,
            this.backgroundColorForTextureViewerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // numMipmapsToolStripMenuItem
            // 
            this.numMipmapsToolStripMenuItem.Name = "numMipmapsToolStripMenuItem";
            this.numMipmapsToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.numMipmapsToolStripMenuItem.Text = "Max Number of Mipmaps";
            // 
            // mipmapInterpolationToolStripMenuItem
            // 
            this.mipmapInterpolationToolStripMenuItem.Name = "mipmapInterpolationToolStripMenuItem";
            this.mipmapInterpolationToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.mipmapInterpolationToolStripMenuItem.Text = "Mipmap Interpolation";
            // 
            // deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem
            // 
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem.CheckOnClick = true;
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem.Name = "deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem";
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem.Text = "Delete Textures Left Unused on Model Deletion";
            this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem.CheckedChanged += new System.EventHandler(this.deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem_CheckedChanged);
            // 
            // showValuesAsHexadecimalToolStripMenuItem
            // 
            this.showValuesAsHexadecimalToolStripMenuItem.Checked = true;
            this.showValuesAsHexadecimalToolStripMenuItem.CheckOnClick = true;
            this.showValuesAsHexadecimalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showValuesAsHexadecimalToolStripMenuItem.Name = "showValuesAsHexadecimalToolStripMenuItem";
            this.showValuesAsHexadecimalToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.showValuesAsHexadecimalToolStripMenuItem.Text = "Show Indices as Hexadecimal";
            this.showValuesAsHexadecimalToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showValuesAsHexadecimalToolStripMenuItem_CheckedChanged);
            // 
            // backgroundColorForTextureViewerToolStripMenuItem
            // 
            this.backgroundColorForTextureViewerToolStripMenuItem.Name = "backgroundColorForTextureViewerToolStripMenuItem";
            this.backgroundColorForTextureViewerToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.backgroundColorForTextureViewerToolStripMenuItem.Text = "Set Background Color for Texture Viewer";
            this.backgroundColorForTextureViewerToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorForTextureViewerToolStripMenuItem_Click);
            // 
            // meshMenuStrip
            // 
            this.meshMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFlagsToolStripMenuItem1});
            this.meshMenuStrip.Name = "meshMenuStrip";
            this.meshMenuStrip.Size = new System.Drawing.Size(134, 26);
            // 
            // editFlagsToolStripMenuItem1
            // 
            this.editFlagsToolStripMenuItem1.Name = "editFlagsToolStripMenuItem1";
            this.editFlagsToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.editFlagsToolStripMenuItem1.Text = "Edit Flags...";
            this.editFlagsToolStripMenuItem1.Click += new System.EventHandler(this.editMeshFlagstoolStripMenuItem_Click);
            // 
            // sfdModelExportPath
            // 
            this.sfdModelExportPath.DefaultExt = "obj";
            this.sfdModelExportPath.Filter = "OBJ Files|*.obj|All Files|*.*";
            this.sfdModelExportPath.Title = "Save Model File...";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // regenerateMipmapsForSelectedToolStripMenuItem
            // 
            this.regenerateMipmapsForSelectedToolStripMenuItem.Name = "regenerateMipmapsForSelectedToolStripMenuItem";
            this.regenerateMipmapsForSelectedToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.regenerateMipmapsForSelectedToolStripMenuItem.Text = "Regenerate Mipmaps for Selected";
            this.regenerateMipmapsForSelectedToolStripMenuItem.Click += new System.EventHandler(this.regenerateMipmapsForSelectedToolStripMenuItem_Click);
            // 
            // regenerateMipmapsForAllToolStripMenuItem
            // 
            this.regenerateMipmapsForAllToolStripMenuItem.Name = "regenerateMipmapsForAllToolStripMenuItem";
            this.regenerateMipmapsForAllToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.regenerateMipmapsForAllToolStripMenuItem.Text = "Regenerate Mipmaps for All";
            this.regenerateMipmapsForAllToolStripMenuItem.Click += new System.EventHandler(this.regenerateMipmapsForAllToolStripMenuItem_Click);
            // 
            // splitContainerModels
            // 
            this.splitContainerModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerModels.Location = new System.Drawing.Point(0, 0);
            this.splitContainerModels.Name = "splitContainerModels";
            // 
            // splitContainerModels.Panel1
            // 
            this.splitContainerModels.Panel1.Controls.Add(this.tableLayoutPanelModelSelect);
            // 
            // splitContainerModels.Panel2
            // 
            this.splitContainerModels.Panel2.Controls.Add(this.tlpMaterialMeshDisplay);
            this.splitContainerModels.Size = new System.Drawing.Size(929, 496);
            this.splitContainerModels.SplitterDistance = 307;
            this.splitContainerModels.TabIndex = 1;
            // 
            // tableLayoutPanelModelSelect
            // 
            this.tableLayoutPanelModelSelect.ColumnCount = 1;
            this.tableLayoutPanelModelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelModelSelect.Controls.Add(this.btnModelHideAll, 0, 4);
            this.tableLayoutPanelModelSelect.Controls.Add(this.btnModelShowLayer1, 0, 2);
            this.tableLayoutPanelModelSelect.Controls.Add(this.btnModelShowLayer2, 0, 3);
            this.tableLayoutPanelModelSelect.Controls.Add(this.btnModelShowAll, 0, 1);
            this.tableLayoutPanelModelSelect.Controls.Add(this.treeModel, 0, 0);
            this.tableLayoutPanelModelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelModelSelect.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelModelSelect.Name = "tableLayoutPanelModelSelect";
            this.tableLayoutPanelModelSelect.RowCount = 5;
            this.tableLayoutPanelModelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelModelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelModelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelModelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelModelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelModelSelect.Size = new System.Drawing.Size(307, 496);
            this.tableLayoutPanelModelSelect.TabIndex = 6;
            // 
            // btnModelHideAll
            // 
            this.btnModelHideAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelHideAll.Location = new System.Drawing.Point(3, 469);
            this.btnModelHideAll.Name = "btnModelHideAll";
            this.btnModelHideAll.Size = new System.Drawing.Size(301, 24);
            this.btnModelHideAll.TabIndex = 4;
            this.btnModelHideAll.Text = "Hide All";
            this.btnModelHideAll.UseVisualStyleBackColor = true;
            this.btnModelHideAll.Click += new System.EventHandler(this.btnModelHideAll_Click);
            // 
            // btnModelShowLayer1
            // 
            this.btnModelShowLayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowLayer1.Location = new System.Drawing.Point(3, 409);
            this.btnModelShowLayer1.Name = "btnModelShowLayer1";
            this.btnModelShowLayer1.Size = new System.Drawing.Size(301, 24);
            this.btnModelShowLayer1.TabIndex = 2;
            this.btnModelShowLayer1.Text = "Show Layer 1 (Opaque) Only";
            this.btnModelShowLayer1.UseVisualStyleBackColor = true;
            this.btnModelShowLayer1.Click += new System.EventHandler(this.btnModelShowLayer1_Click);
            // 
            // btnModelShowLayer2
            // 
            this.btnModelShowLayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowLayer2.Location = new System.Drawing.Point(3, 439);
            this.btnModelShowLayer2.Name = "btnModelShowLayer2";
            this.btnModelShowLayer2.Size = new System.Drawing.Size(301, 24);
            this.btnModelShowLayer2.TabIndex = 3;
            this.btnModelShowLayer2.Text = "Show Layer 2 (Transparent) Only";
            this.btnModelShowLayer2.UseVisualStyleBackColor = true;
            this.btnModelShowLayer2.Click += new System.EventHandler(this.btnModelShowLayer2_Click);
            // 
            // btnModelShowAll
            // 
            this.btnModelShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModelShowAll.Location = new System.Drawing.Point(3, 379);
            this.btnModelShowAll.Name = "btnModelShowAll";
            this.btnModelShowAll.Size = new System.Drawing.Size(301, 24);
            this.btnModelShowAll.TabIndex = 1;
            this.btnModelShowAll.Text = "Show All";
            this.btnModelShowAll.UseVisualStyleBackColor = true;
            this.btnModelShowAll.Click += new System.EventHandler(this.btnModelShowAll_Click);
            // 
            // treeModel
            // 
            this.treeModel.AllowDrop = true;
            this.treeModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeModel.LabelEdit = true;
            this.treeModel.Location = new System.Drawing.Point(3, 3);
            this.treeModel.Name = "treeModel";
            this.treeModel.SelectedNodes = ((System.Collections.Generic.List<System.Windows.Forms.TreeNode>)(resources.GetObject("treeModel.SelectedNodes")));
            this.treeModel.Size = new System.Drawing.Size(301, 370);
            this.treeModel.TabIndex = 0;
            this.treeModel.AfterCheckState += new System.Windows.Forms.TreeViewEventHandler(this.treeModel_AfterCheckState);
            this.treeModel.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeModel_BeforeLabelEdit);
            this.treeModel.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeModel_AfterLabelEdit);
            this.treeModel.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeModel_ItemDrag);
            this.treeModel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeModel_AfterSelect);
            this.treeModel.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeModel_DragDrop);
            this.treeModel.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeModel_DragEnter);
            this.treeModel.DragOver += new System.Windows.Forms.DragEventHandler(this.treeModel_DragOver);
            this.treeModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeModel_MouseDown);
            // 
            // tlpMaterialMeshDisplay
            // 
            this.tlpMaterialMeshDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMaterialMeshDisplay.ColumnCount = 1;
            this.tlpMaterialMeshDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterialMeshDisplay.Controls.Add(this.tlpModelDisplay, 0, 1);
            this.tlpMaterialMeshDisplay.Controls.Add(this.glControlModel, 0, 0);
            this.tlpMaterialMeshDisplay.Controls.Add(this.tlpMeshDisplay, 0, 2);
            this.tlpMaterialMeshDisplay.Location = new System.Drawing.Point(2, 3);
            this.tlpMaterialMeshDisplay.Name = "tlpMaterialMeshDisplay";
            this.tlpMaterialMeshDisplay.RowCount = 3;
            this.tlpMaterialMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterialMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterialMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterialMeshDisplay.Size = new System.Drawing.Size(616, 487);
            this.tlpMaterialMeshDisplay.TabIndex = 1;
            // 
            // tlpModelDisplay
            // 
            this.tlpModelDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpModelDisplay.ColumnCount = 2;
            this.tlpModelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModelDisplay.Controls.Add(this.lblModelSectionFlagsText, 0, 0);
            this.tlpModelDisplay.Controls.Add(this.lblModelCenterText, 0, 1);
            this.tlpModelDisplay.Controls.Add(this.lblModelRadiusText, 0, 2);
            this.tlpModelDisplay.Controls.Add(this.lblModelTransformMatrixDefaultReferencesText, 0, 3);
            this.tlpModelDisplay.Controls.Add(this.lblModelNumTransformMatricesText, 0, 4);
            this.tlpModelDisplay.Controls.Add(this.lblModelSectionFlags, 1, 0);
            this.tlpModelDisplay.Controls.Add(this.lblModelCenter, 1, 1);
            this.tlpModelDisplay.Controls.Add(this.lblModelRadius, 1, 2);
            this.tlpModelDisplay.Controls.Add(this.lblModelTransformMatrixDefaultReferences, 1, 3);
            this.tlpModelDisplay.Controls.Add(this.lblModelNumTransformMatrices, 1, 4);
            this.tlpModelDisplay.Location = new System.Drawing.Point(3, 98);
            this.tlpModelDisplay.Name = "tlpModelDisplay";
            this.tlpModelDisplay.RowCount = 5;
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpModelDisplay.Size = new System.Drawing.Size(610, 100);
            this.tlpModelDisplay.TabIndex = 0;
            // 
            // lblModelSectionFlagsText
            // 
            this.lblModelSectionFlagsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelSectionFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelSectionFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblModelSectionFlagsText.Name = "lblModelSectionFlagsText";
            this.lblModelSectionFlagsText.Size = new System.Drawing.Size(299, 20);
            this.lblModelSectionFlagsText.TabIndex = 0;
            this.lblModelSectionFlagsText.Text = "Section Flags:";
            this.lblModelSectionFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelCenterText
            // 
            this.lblModelCenterText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCenterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCenterText.Location = new System.Drawing.Point(3, 20);
            this.lblModelCenterText.Name = "lblModelCenterText";
            this.lblModelCenterText.Size = new System.Drawing.Size(299, 20);
            this.lblModelCenterText.TabIndex = 1;
            this.lblModelCenterText.Text = "Center (X,Y,Z):";
            this.lblModelCenterText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelRadiusText
            // 
            this.lblModelRadiusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelRadiusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelRadiusText.Location = new System.Drawing.Point(3, 40);
            this.lblModelRadiusText.Name = "lblModelRadiusText";
            this.lblModelRadiusText.Size = new System.Drawing.Size(299, 20);
            this.lblModelRadiusText.TabIndex = 2;
            this.lblModelRadiusText.Text = "Radius:";
            this.lblModelRadiusText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelTransformMatrixDefaultReferencesText
            // 
            this.lblModelTransformMatrixDefaultReferencesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelTransformMatrixDefaultReferencesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelTransformMatrixDefaultReferencesText.Location = new System.Drawing.Point(3, 60);
            this.lblModelTransformMatrixDefaultReferencesText.Name = "lblModelTransformMatrixDefaultReferencesText";
            this.lblModelTransformMatrixDefaultReferencesText.Size = new System.Drawing.Size(299, 20);
            this.lblModelTransformMatrixDefaultReferencesText.TabIndex = 3;
            this.lblModelTransformMatrixDefaultReferencesText.Text = "Transform Matrix Default Idxs:";
            this.lblModelTransformMatrixDefaultReferencesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelNumTransformMatricesText
            // 
            this.lblModelNumTransformMatricesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelNumTransformMatricesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelNumTransformMatricesText.Location = new System.Drawing.Point(3, 80);
            this.lblModelNumTransformMatricesText.Name = "lblModelNumTransformMatricesText";
            this.lblModelNumTransformMatricesText.Size = new System.Drawing.Size(299, 20);
            this.lblModelNumTransformMatricesText.TabIndex = 4;
            this.lblModelNumTransformMatricesText.Text = "Num. Transform Matrix:";
            this.lblModelNumTransformMatricesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblModelSectionFlags
            // 
            this.lblModelSectionFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelSectionFlags.Location = new System.Drawing.Point(308, 0);
            this.lblModelSectionFlags.Name = "lblModelSectionFlags";
            this.lblModelSectionFlags.Size = new System.Drawing.Size(299, 20);
            this.lblModelSectionFlags.TabIndex = 5;
            this.lblModelSectionFlags.Text = "-";
            // 
            // lblModelCenter
            // 
            this.lblModelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelCenter.Location = new System.Drawing.Point(308, 20);
            this.lblModelCenter.Name = "lblModelCenter";
            this.lblModelCenter.Size = new System.Drawing.Size(299, 20);
            this.lblModelCenter.TabIndex = 6;
            this.lblModelCenter.Text = "-";
            // 
            // lblModelRadius
            // 
            this.lblModelRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelRadius.Location = new System.Drawing.Point(308, 40);
            this.lblModelRadius.Name = "lblModelRadius";
            this.lblModelRadius.Size = new System.Drawing.Size(299, 20);
            this.lblModelRadius.TabIndex = 7;
            this.lblModelRadius.Text = "-";
            // 
            // lblModelTransformMatrixDefaultReferences
            // 
            this.lblModelTransformMatrixDefaultReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelTransformMatrixDefaultReferences.Location = new System.Drawing.Point(308, 60);
            this.lblModelTransformMatrixDefaultReferences.Name = "lblModelTransformMatrixDefaultReferences";
            this.lblModelTransformMatrixDefaultReferences.Size = new System.Drawing.Size(299, 20);
            this.lblModelTransformMatrixDefaultReferences.TabIndex = 8;
            this.lblModelTransformMatrixDefaultReferences.Text = "-";
            // 
            // lblModelNumTransformMatrices
            // 
            this.lblModelNumTransformMatrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelNumTransformMatrices.Location = new System.Drawing.Point(308, 80);
            this.lblModelNumTransformMatrices.Name = "lblModelNumTransformMatrices";
            this.lblModelNumTransformMatrices.Size = new System.Drawing.Size(299, 20);
            this.lblModelNumTransformMatrices.TabIndex = 9;
            this.lblModelNumTransformMatrices.Text = "-";
            // 
            // glControlModel
            // 
            this.glControlModel.BackColor = System.Drawing.Color.Black;
            this.glControlModel.ContextMenuStrip = this.ctxMenuModelOptions;
            this.glControlModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControlModel.Location = new System.Drawing.Point(3, 3);
            this.glControlModel.Name = "glControlModel";
            this.glControlModel.Size = new System.Drawing.Size(610, 89);
            this.glControlModel.TabIndex = 0;
            this.glControlModel.VSync = false;
            this.glControlModel.Load += new System.EventHandler(this.glControlModel_Load);
            this.glControlModel.Paint += new System.Windows.Forms.PaintEventHandler(this.glControlModel_Paint);
            this.glControlModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControlModel_MouseDown);
            this.glControlModel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControlModel_MouseMove);
            this.glControlModel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControlModel_MouseUp);
            this.glControlModel.Resize += new System.EventHandler(this.glControlModel_Resize);
            // 
            // tlpMeshDisplay
            // 
            this.tlpMeshDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMeshDisplay.ColumnCount = 2;
            this.tlpMeshDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMeshDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk12, 1, 5);
            this.tlpMeshDisplay.Controls.Add(this.label1, 0, 5);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshRenderFlagsText, 0, 0);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk4Text, 0, 1);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk8Text, 0, 2);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnkCText, 0, 3);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk10Text, 0, 4);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk14Text, 0, 6);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshPrimaryMaterialIdxText, 0, 7);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshSecondaryMaterialIdxText, 0, 8);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshTertiaryMaterialIdxText, 0, 9);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshTransformMatrixSpecificReferencesText, 0, 10);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshCenterText, 0, 11);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk3CText, 0, 12);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk40Text, 0, 13);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk40, 1, 13);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk3C, 1, 12);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshCenter, 1, 11);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshTransformMatrixSpecificReferences, 1, 10);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshTertiaryMaterialIdx, 1, 9);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshSecondaryMaterialIdx, 1, 8);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshPrimaryMaterialIdx, 1, 7);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk14, 1, 6);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk10, 1, 4);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnkC, 1, 3);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk8, 1, 2);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshUnk4, 1, 1);
            this.tlpMeshDisplay.Controls.Add(this.lblMeshRenderFlags, 1, 0);
            this.tlpMeshDisplay.Location = new System.Drawing.Point(3, 204);
            this.tlpMeshDisplay.Name = "tlpMeshDisplay";
            this.tlpMeshDisplay.RowCount = 14;
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeshDisplay.Size = new System.Drawing.Size(610, 280);
            this.tlpMeshDisplay.TabIndex = 1;
            // 
            // lblMeshUnk12
            // 
            this.lblMeshUnk12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk12.Location = new System.Drawing.Point(308, 100);
            this.lblMeshUnk12.Name = "lblMeshUnk12";
            this.lblMeshUnk12.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk12.TabIndex = 30;
            this.lblMeshUnk12.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Material Count (0x12):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshRenderFlagsText
            // 
            this.lblMeshRenderFlagsText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshRenderFlagsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshRenderFlagsText.Location = new System.Drawing.Point(3, 0);
            this.lblMeshRenderFlagsText.Name = "lblMeshRenderFlagsText";
            this.lblMeshRenderFlagsText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshRenderFlagsText.TabIndex = 0;
            this.lblMeshRenderFlagsText.Text = "Render Flags (0x00):";
            this.lblMeshRenderFlagsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk4Text
            // 
            this.lblMeshUnk4Text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnk4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk4Text.Location = new System.Drawing.Point(3, 20);
            this.lblMeshUnk4Text.Name = "lblMeshUnk4Text";
            this.lblMeshUnk4Text.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk4Text.TabIndex = 1;
            this.lblMeshUnk4Text.Text = "Vertex Shading A (0x04):";
            this.lblMeshUnk4Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk8Text
            // 
            this.lblMeshUnk8Text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnk8Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk8Text.Location = new System.Drawing.Point(3, 40);
            this.lblMeshUnk8Text.Name = "lblMeshUnk8Text";
            this.lblMeshUnk8Text.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk8Text.TabIndex = 2;
            this.lblMeshUnk8Text.Text = "Vertex Shading B (0x08):";
            this.lblMeshUnk8Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnkCText
            // 
            this.lblMeshUnkCText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnkCText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnkCText.Location = new System.Drawing.Point(3, 60);
            this.lblMeshUnkCText.Name = "lblMeshUnkCText";
            this.lblMeshUnkCText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnkCText.TabIndex = 3;
            this.lblMeshUnkCText.Text = "Specular Tint (0x0C):";
            this.lblMeshUnkCText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk10Text
            // 
            this.lblMeshUnk10Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk10Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk10Text.Location = new System.Drawing.Point(3, 80);
            this.lblMeshUnk10Text.Name = "lblMeshUnk10Text";
            this.lblMeshUnk10Text.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk10Text.TabIndex = 4;
            this.lblMeshUnk10Text.Text = "Transparency (0x10):";
            this.lblMeshUnk10Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk14Text
            // 
            this.lblMeshUnk14Text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnk14Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk14Text.Location = new System.Drawing.Point(3, 120);
            this.lblMeshUnk14Text.Name = "lblMeshUnk14Text";
            this.lblMeshUnk14Text.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk14Text.TabIndex = 5;
            this.lblMeshUnk14Text.Text = "Unknown (0x14):";
            this.lblMeshUnk14Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshPrimaryMaterialIdxText
            // 
            this.lblMeshPrimaryMaterialIdxText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshPrimaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshPrimaryMaterialIdxText.Location = new System.Drawing.Point(3, 140);
            this.lblMeshPrimaryMaterialIdxText.Name = "lblMeshPrimaryMaterialIdxText";
            this.lblMeshPrimaryMaterialIdxText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshPrimaryMaterialIdxText.TabIndex = 6;
            this.lblMeshPrimaryMaterialIdxText.Text = "Primary Material Index (Dec) (0x16):";
            this.lblMeshPrimaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshSecondaryMaterialIdxText
            // 
            this.lblMeshSecondaryMaterialIdxText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshSecondaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshSecondaryMaterialIdxText.Location = new System.Drawing.Point(3, 160);
            this.lblMeshSecondaryMaterialIdxText.Name = "lblMeshSecondaryMaterialIdxText";
            this.lblMeshSecondaryMaterialIdxText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshSecondaryMaterialIdxText.TabIndex = 7;
            this.lblMeshSecondaryMaterialIdxText.Text = "Secondary Material Index (Dec) (0x18):";
            this.lblMeshSecondaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshTertiaryMaterialIdxText
            // 
            this.lblMeshTertiaryMaterialIdxText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshTertiaryMaterialIdxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshTertiaryMaterialIdxText.Location = new System.Drawing.Point(3, 180);
            this.lblMeshTertiaryMaterialIdxText.Name = "lblMeshTertiaryMaterialIdxText";
            this.lblMeshTertiaryMaterialIdxText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshTertiaryMaterialIdxText.TabIndex = 8;
            this.lblMeshTertiaryMaterialIdxText.Text = "Tertiary Material Index (Dec) (0x1A):";
            this.lblMeshTertiaryMaterialIdxText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshTransformMatrixSpecificReferencesText
            // 
            this.lblMeshTransformMatrixSpecificReferencesText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshTransformMatrixSpecificReferencesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshTransformMatrixSpecificReferencesText.Location = new System.Drawing.Point(3, 200);
            this.lblMeshTransformMatrixSpecificReferencesText.Name = "lblMeshTransformMatrixSpecificReferencesText";
            this.lblMeshTransformMatrixSpecificReferencesText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshTransformMatrixSpecificReferencesText.TabIndex = 10;
            this.lblMeshTransformMatrixSpecificReferencesText.Text = "Transform Matrix Specific Indices:";
            this.lblMeshTransformMatrixSpecificReferencesText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshCenterText
            // 
            this.lblMeshCenterText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshCenterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshCenterText.Location = new System.Drawing.Point(3, 220);
            this.lblMeshCenterText.Name = "lblMeshCenterText";
            this.lblMeshCenterText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshCenterText.TabIndex = 11;
            this.lblMeshCenterText.Text = "Center (X,Y,Z):";
            this.lblMeshCenterText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk3CText
            // 
            this.lblMeshUnk3CText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnk3CText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk3CText.Location = new System.Drawing.Point(3, 240);
            this.lblMeshUnk3CText.Name = "lblMeshUnk3CText";
            this.lblMeshUnk3CText.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk3CText.TabIndex = 12;
            this.lblMeshUnk3CText.Text = "Unknown (0x3C):";
            this.lblMeshUnk3CText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk40Text
            // 
            this.lblMeshUnk40Text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMeshUnk40Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeshUnk40Text.Location = new System.Drawing.Point(3, 260);
            this.lblMeshUnk40Text.Name = "lblMeshUnk40Text";
            this.lblMeshUnk40Text.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk40Text.TabIndex = 13;
            this.lblMeshUnk40Text.Text = "Unknown (0x40):";
            this.lblMeshUnk40Text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMeshUnk40
            // 
            this.lblMeshUnk40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk40.Location = new System.Drawing.Point(308, 260);
            this.lblMeshUnk40.Name = "lblMeshUnk40";
            this.lblMeshUnk40.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk40.TabIndex = 14;
            this.lblMeshUnk40.Text = "-";
            // 
            // lblMeshUnk3C
            // 
            this.lblMeshUnk3C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk3C.Location = new System.Drawing.Point(308, 240);
            this.lblMeshUnk3C.Name = "lblMeshUnk3C";
            this.lblMeshUnk3C.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk3C.TabIndex = 15;
            this.lblMeshUnk3C.Text = "-";
            // 
            // lblMeshCenter
            // 
            this.lblMeshCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshCenter.Location = new System.Drawing.Point(308, 220);
            this.lblMeshCenter.Name = "lblMeshCenter";
            this.lblMeshCenter.Size = new System.Drawing.Size(299, 20);
            this.lblMeshCenter.TabIndex = 16;
            this.lblMeshCenter.Text = "-";
            // 
            // lblMeshTransformMatrixSpecificReferences
            // 
            this.lblMeshTransformMatrixSpecificReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTransformMatrixSpecificReferences.Location = new System.Drawing.Point(308, 200);
            this.lblMeshTransformMatrixSpecificReferences.Name = "lblMeshTransformMatrixSpecificReferences";
            this.lblMeshTransformMatrixSpecificReferences.Size = new System.Drawing.Size(299, 20);
            this.lblMeshTransformMatrixSpecificReferences.TabIndex = 17;
            this.lblMeshTransformMatrixSpecificReferences.Text = "-";
            // 
            // lblMeshTertiaryMaterialIdx
            // 
            this.lblMeshTertiaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshTertiaryMaterialIdx.Location = new System.Drawing.Point(308, 180);
            this.lblMeshTertiaryMaterialIdx.Name = "lblMeshTertiaryMaterialIdx";
            this.lblMeshTertiaryMaterialIdx.Size = new System.Drawing.Size(299, 20);
            this.lblMeshTertiaryMaterialIdx.TabIndex = 19;
            this.lblMeshTertiaryMaterialIdx.Text = "-";
            // 
            // lblMeshSecondaryMaterialIdx
            // 
            this.lblMeshSecondaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshSecondaryMaterialIdx.Location = new System.Drawing.Point(308, 160);
            this.lblMeshSecondaryMaterialIdx.Name = "lblMeshSecondaryMaterialIdx";
            this.lblMeshSecondaryMaterialIdx.Size = new System.Drawing.Size(299, 20);
            this.lblMeshSecondaryMaterialIdx.TabIndex = 20;
            this.lblMeshSecondaryMaterialIdx.Text = "-";
            // 
            // lblMeshPrimaryMaterialIdx
            // 
            this.lblMeshPrimaryMaterialIdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshPrimaryMaterialIdx.Location = new System.Drawing.Point(308, 140);
            this.lblMeshPrimaryMaterialIdx.Name = "lblMeshPrimaryMaterialIdx";
            this.lblMeshPrimaryMaterialIdx.Size = new System.Drawing.Size(299, 20);
            this.lblMeshPrimaryMaterialIdx.TabIndex = 21;
            this.lblMeshPrimaryMaterialIdx.Text = "-";
            // 
            // lblMeshUnk14
            // 
            this.lblMeshUnk14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk14.Location = new System.Drawing.Point(308, 120);
            this.lblMeshUnk14.Name = "lblMeshUnk14";
            this.lblMeshUnk14.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk14.TabIndex = 22;
            this.lblMeshUnk14.Text = "-";
            // 
            // lblMeshUnk10
            // 
            this.lblMeshUnk10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk10.Location = new System.Drawing.Point(308, 80);
            this.lblMeshUnk10.Name = "lblMeshUnk10";
            this.lblMeshUnk10.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk10.TabIndex = 23;
            this.lblMeshUnk10.Text = "-";
            // 
            // lblMeshUnkC
            // 
            this.lblMeshUnkC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnkC.Location = new System.Drawing.Point(308, 60);
            this.lblMeshUnkC.Name = "lblMeshUnkC";
            this.lblMeshUnkC.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnkC.TabIndex = 24;
            this.lblMeshUnkC.Text = "-";
            // 
            // lblMeshUnk8
            // 
            this.lblMeshUnk8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk8.Location = new System.Drawing.Point(308, 40);
            this.lblMeshUnk8.Name = "lblMeshUnk8";
            this.lblMeshUnk8.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk8.TabIndex = 25;
            this.lblMeshUnk8.Text = "-";
            // 
            // lblMeshUnk4
            // 
            this.lblMeshUnk4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshUnk4.Location = new System.Drawing.Point(308, 20);
            this.lblMeshUnk4.Name = "lblMeshUnk4";
            this.lblMeshUnk4.Size = new System.Drawing.Size(299, 20);
            this.lblMeshUnk4.TabIndex = 26;
            this.lblMeshUnk4.Text = "-";
            // 
            // lblMeshRenderFlags
            // 
            this.lblMeshRenderFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeshRenderFlags.Location = new System.Drawing.Point(308, 0);
            this.lblMeshRenderFlags.Name = "lblMeshRenderFlags";
            this.lblMeshRenderFlags.Size = new System.Drawing.Size(299, 20);
            this.lblMeshRenderFlags.TabIndex = 27;
            this.lblMeshRenderFlags.Text = "-";
            // 
            // treeMaterials
            // 
            this.treeMaterials.ContextMenuStrip = this.materialMenuStrip;
            this.treeMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMaterials.Location = new System.Drawing.Point(0, 0);
            this.treeMaterials.Name = "treeMaterials";
            this.treeMaterials.SelectedNodes = ((System.Collections.Generic.List<System.Windows.Forms.TreeNode>)(resources.GetObject("treeMaterials.SelectedNodes")));
            this.treeMaterials.Size = new System.Drawing.Size(306, 490);
            this.treeMaterials.TabIndex = 0;
            this.treeMaterials.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMaterials_AfterSelect);
            this.treeMaterials.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeMaterials_MouseDown);
            // 
            // pbMaterialTextureImage
            // 
            this.pbMaterialTextureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMaterialTextureImage.Location = new System.Drawing.Point(3, 3);
            this.pbMaterialTextureImage.Name = "pbMaterialTextureImage";
            this.pbMaterialTextureImage.Size = new System.Drawing.Size(601, 350);
            this.pbMaterialTextureImage.TabIndex = 2;
            this.pbMaterialTextureImage.TabStop = false;
            // 
            // pbTextureImage
            // 
            this.pbTextureImage.BackColor = System.Drawing.Color.Transparent;
            this.pbTextureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTextureImage.Location = new System.Drawing.Point(3, 3);
            this.pbTextureImage.Name = "pbTextureImage";
            this.pbTextureImage.Size = new System.Drawing.Size(602, 372);
            this.pbTextureImage.TabIndex = 4;
            this.pbTextureImage.TabStop = false;
            // 
            // changeFormatToolStripMenuItem
            // 
            this.changeFormatToolStripMenuItem.Name = "changeFormatToolStripMenuItem";
            this.changeFormatToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.changeFormatToolStripMenuItem.Text = "Change Format...";
            this.changeFormatToolStripMenuItem.Click += new System.EventHandler(this.changeFormatToolStripMenuItem_Click);
            // 
            // ModelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 586);
            this.Controls.Add(this.tabControlModelsTextures);
            this.Controls.Add(this.toolStripActions);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModelViewer";
            this.Text = "GxModelViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelViewer_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModelViewer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModelViewer_KeyUp);
            this.ctxMenuModelOptions.ResumeLayout(false);
            this.toolStripActions.ResumeLayout(false);
            this.toolStripActions.PerformLayout();
            this.tabControlModelsTextures.ResumeLayout(false);
            this.tabPageModels.ResumeLayout(false);
            this.tabPageMaterials.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.materialMenuStrip.ResumeLayout(false);
            this.tlpMaterialDisplay.ResumeLayout(false);
            this.tlpMaterialProperties.ResumeLayout(false);
            this.tabPageTextures.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.textureMenuStrip.ResumeLayout(false);
            this.tlpTextureDisplay.ResumeLayout(false);
            this.tlpTextureProperties.ResumeLayout(false);
            this.tlpTextureProperties.PerformLayout();
            this.gmaContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.meshMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.splitContainerModels.Panel1.ResumeLayout(false);
            this.splitContainerModels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerModels)).EndInit();
            this.splitContainerModels.ResumeLayout(false);
            this.tableLayoutPanelModelSelect.ResumeLayout(false);
            this.tlpMaterialMeshDisplay.ResumeLayout(false);
            this.tlpModelDisplay.ResumeLayout(false);
            this.tlpMeshDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialTextureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTextureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControlModel;
        private System.Windows.Forms.ToolStrip toolStripActions;
        private System.Windows.Forms.ToolStripLabel lsLblGame;
        private System.Windows.Forms.ToolStripComboBox tsCmbGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnLoadGma;
        private System.Windows.Forms.ToolStripButton tsBtnLoadTpl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSaveTpl;
        private System.Windows.Forms.ToolStripButton tsBtnSaveTplAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnExportObjMtl;
        private System.Windows.Forms.TabControl tabControlModelsTextures;
        private System.Windows.Forms.TabPage tabPageModels;
        private System.Windows.Forms.SplitContainer splitContainerModels;
        private System.Windows.Forms.TabPage tabPageTextures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelModelSelect;
        private System.Windows.Forms.Button btnModelHideAll;
        private System.Windows.Forms.Button btnModelShowLayer1;
        private System.Windows.Forms.Button btnModelShowLayer2;
        private System.Windows.Forms.Button btnModelShowAll;
        private GxModelViewer_WinFormsExt.TreeViewAutoPartialCheckBox treeModel;
        private System.Windows.Forms.TabPage tabPageMaterials;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeTextures;
        private System.Windows.Forms.OpenFileDialog ofdLoadGma;
        private System.Windows.Forms.OpenFileDialog ofdLoadTpl;
        private System.Windows.Forms.SaveFileDialog sfdSaveTpl;
        private System.Windows.Forms.ContextMenuStrip ctxMenuModelOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowTextures;
        private TreeViewMS.TreeViewMS treeMaterials;
        private System.Windows.Forms.Button btnImportTextureLevel;
        private System.Windows.Forms.Button btnExportTextureLevel;
        private System.Windows.Forms.OpenFileDialog ofdTextureImportPath;
        private System.Windows.Forms.SaveFileDialog sfdTextureExportPath;
        private System.Windows.Forms.TableLayoutPanel tlpTextureDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpTextureProperties;
        private System.Windows.Forms.Label lblTextureDimensionsText;
        private System.Windows.Forms.Label lblTextureDimensions;
        private System.Windows.Forms.Label lblTextureFormatText;
        private System.Windows.Forms.Label lblTextureFormat;
        private System.Windows.Forms.TableLayoutPanel tlpMaterialDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpMaterialProperties;
        private System.Windows.Forms.Label lblMaterialFlagsText;
        private System.Windows.Forms.Label lblMaterialTextureIndexText;
        private System.Windows.Forms.Label lblMaterialUnk6Text;
        private System.Windows.Forms.Label lblMaterialAnisotropyLevelText;
        private System.Windows.Forms.Label lblMaterialUnkCText;
        private System.Windows.Forms.Label lblMaterialUnk10Text;
        private System.Windows.Forms.Label lblMaterialFlags;
        private System.Windows.Forms.Label lblMaterialTextureIndex;
        private System.Windows.Forms.Label lblMaterialUnk6;
        private System.Windows.Forms.Label lblMaterialAnisotropyLevel;
        private System.Windows.Forms.Label lblMaterialUnkC;
        private System.Windows.Forms.Label lblMaterialUnk10;
        private GxModelViewer_WinFormsExt.PictureBoxDownsizeIfNecessary pbTextureImage;
        private PictureBoxDownsizeIfNecessary pbMaterialTextureImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemResetViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TableLayoutPanel tlpMaterialMeshDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpModelDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpMeshDisplay;
        private System.Windows.Forms.Label lblMeshRenderFlagsText;
        private System.Windows.Forms.Label lblModelSectionFlagsText;
        private System.Windows.Forms.Label lblModelCenterText;
        private System.Windows.Forms.Label lblModelRadiusText;
        private System.Windows.Forms.Label lblModelTransformMatrixDefaultReferencesText;
        private System.Windows.Forms.Label lblModelNumTransformMatricesText;
        private System.Windows.Forms.Label lblModelSectionFlags;
        private System.Windows.Forms.Label lblModelCenter;
        private System.Windows.Forms.Label lblModelRadius;
        private System.Windows.Forms.Label lblModelTransformMatrixDefaultReferences;
        private System.Windows.Forms.Label lblModelNumTransformMatrices;
        private System.Windows.Forms.Label lblMeshUnk4Text;
        private System.Windows.Forms.Label lblMeshUnk8Text;
        private System.Windows.Forms.Label lblMeshUnkCText;
        private System.Windows.Forms.Label lblMeshUnk10Text;
        private System.Windows.Forms.Label lblMeshUnk14Text;
        private System.Windows.Forms.Label lblMeshPrimaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshSecondaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshTertiaryMaterialIdxText;
        private System.Windows.Forms.Label lblMeshTransformMatrixSpecificReferencesText;
        private System.Windows.Forms.Label lblMeshCenterText;
        private System.Windows.Forms.Label lblMeshUnk3CText;
        private System.Windows.Forms.Label lblMeshUnk40Text;
        private System.Windows.Forms.Label lblMeshUnk40;
        private System.Windows.Forms.Label lblMeshUnk3C;
        private System.Windows.Forms.Label lblMeshCenter;
        private System.Windows.Forms.Label lblMeshTransformMatrixSpecificReferences;
        private System.Windows.Forms.Label lblMeshTertiaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshSecondaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshPrimaryMaterialIdx;
        private System.Windows.Forms.Label lblMeshUnk14;
        private System.Windows.Forms.Label lblMeshUnk10;
        private System.Windows.Forms.Label lblMeshUnkC;
        private System.Windows.Forms.Label lblMeshUnk8;
        private System.Windows.Forms.Label lblMeshUnk4;
        private System.Windows.Forms.Label lblMeshRenderFlags;
        private System.Windows.Forms.ToolStripButton tsBtnSaveGma;
        private System.Windows.Forms.ToolStripButton tsBtnSaveGmaAs;
        private System.Windows.Forms.ToolStripButton tsBtnImportObjMtl;
        private System.Windows.Forms.SaveFileDialog sfdSaveGma;
        private System.Windows.Forms.OpenFileDialog ofdLoadObj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numMipmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mipmapInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gmaImporttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gmaExportTolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip gmaContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem importPreserveFLagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFlagsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip meshMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editFlagsToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip materialMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editFlagsToolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog sfdModelExportPath;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblMeshUnk12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem defineNewToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip textureMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem defineNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem defineNewFromTextureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importGMATPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsGMATPLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeUnusedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTextureLeftUnusedOnModelDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletenoMaterialAdjustmentToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextureUsedBy;
        private System.Windows.Forms.ToolTip toolTipTextureUsedBy;
        private System.Windows.Forms.ToolStripMenuItem reloadViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showValuesAsHexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorForTextureViewerToolStripMenuItem;
        private System.Windows.Forms.ColorDialog texViewerColorDialog;
        private System.Windows.Forms.ToolStripMenuItem regenerateMipmapsForSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regenerateMipmapsForAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFormatToolStripMenuItem;
    }
}