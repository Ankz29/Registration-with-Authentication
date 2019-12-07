using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
     public  static class UtilityClass
    {
        public   static List<SqlParameter> StoreData(Registration modalData)
        {
             string DBstr = ConfigurationManager.AppSettings["DBConnection"];
                    SqlConnection con = new SqlConnection( DBstr );
                    SqlCommand cmd = new SqlCommand( "SpMyProcedure", con );

                    List<SqlParameter> paramsToStore = new List<SqlParameter>();
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter( "@USER_NAME", SqlDbType.VarChar );
                    param.Value = modalData.UserName;
                    paramsToStore.Add( param );

                    param = new SqlParameter( "@PASSWORD", SqlDbType.NVarChar );
                    param.Value = modalData.Password;
                    paramsToStore.Add( param );

                    param = new SqlParameter( "@PHONE_NUMBER", SqlDbType.Int );
                    param.Value = modalData.PhoneNumber;
                    paramsToStore.Add( param );

                    param = new SqlParameter( "@ADDRESS", SqlDbType.NVarChar );
                    param.Value = modalData.Address;
                    paramsToStore.Add( param );
          
            return paramsToStore;

        }

    }
}