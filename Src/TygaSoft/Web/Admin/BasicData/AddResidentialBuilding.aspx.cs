﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TygaSoft.Model;
using TygaSoft.BLL;
using TygaSoft.WebHelper;

namespace TygaSoft.Web.Admin.BasicData
{
    public partial class AddResidentialBuilding : System.Web.UI.Page
    {
        Guid Id;
        string myDataAppend;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["Id"]))
            {
                Guid.TryParse(Request.QueryString["Id"], out Id);
            }

            if (!Page.IsPostBack)
            {
                string error = "";

                try
                {
                    string myDataForModelInfo = "";
                    Bind(ref myDataForModelInfo);
                    myDataAppend += "<div id=\"myDataForModelInfo\" style=\"display:none;\">[" + myDataForModelInfo + "]</div>";

                    ltrMyData.Text = "<div id=\"myDataAppend\" style=\"display:none;\">" + myDataAppend + "</div>";
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Messager(Page, error, MessageContent.AlertTitle_Ex_Error, "error");
                }
            }
        }

        private void Bind(ref string myDataAppend)
        {
            if (!Id.Equals(Guid.Empty))
            {
                Page.Title = "编辑楼信息";
                ResidentialBuilding bll = new ResidentialBuilding();
                ResidentialBuildingInfo model = bll.GetModelByJoin(Id);
                if (model != null)
                {
                    txtName.Value = model.BuildingCode;
                    txtCoveredArea.Value = model.CoveredArea.ToString();
                    txtaRemark.Value = model.Remark;
                    myDataAppend += "{ \"Id\":\"" + model.Id + "\",\"PropertyCompanyId\":\"" + model.PropertyCompanyId + "\",\"ResidenceCommunityId\":\"" + model.ResidenceCommunityId + "\",\"CompanyName\":\"" + model.CompanyName + "\",\"CommunityName\":\"" + model.CommunityName + "\"}";
                }
            }
        }
    }
}