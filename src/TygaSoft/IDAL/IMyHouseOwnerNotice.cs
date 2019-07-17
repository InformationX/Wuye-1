﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.Model;

namespace TygaSoft.IDAL
{
    public partial interface IHouseOwnerNotice
    {
        #region IUserHouseOwnerNotice Member

        void BulkCopy(DataTable dt);

        List<HouseOwnerNoticeInfo> GetListByJoin(int pageIndex, int pageSize, out int totalRecords, string sqlWhere, params SqlParameter[] cmdParms);

        #endregion
    }
}
