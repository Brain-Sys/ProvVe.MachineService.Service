﻿namespace ProvVe.MachineService.WindowsServiceHost
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProvVeProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ProvVeInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ProvVeProcessInstaller
            // 
            this.ProvVeProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ProvVeProcessInstaller.Password = null;
            this.ProvVeProcessInstaller.Username = null;
            // 
            // ProvVeInstaller
            // 
            this.ProvVeInstaller.DisplayName = "ProvVe";
            this.ProvVeInstaller.ServiceName = "ProvVe";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ProvVeProcessInstaller,
            this.ProvVeInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ProvVeProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ProvVeInstaller;
    }
}