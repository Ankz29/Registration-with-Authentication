using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcApplication1.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/

        public ActionResult Index(Registration registrationModal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UtilityClass.StoreData( registrationModal );

                   // SqlHelper.ExecuteDataset( DBstr, CommandType.StoredProcedure,
                      //      "USP_S_REJECTIONREASON_DETAILS", paramsToStore.ToArray() );
                }

                else
                {
                    ViewData["Message"] = "Data not stored in database, please re-check";
                }
               


                

                // var data = SqlHelper.ExecuteDataset( GetConfigValue( "DBConnection" ), CommandType.StoredProcedure,
                //  "USP_S_REJECTIONREASON_DETAILS", paramsToStore.ToArray() );
            }

            catch(Exception )
            {
                new Exception( "Some exception, please check logs !!!" );
            }
            return View( registrationModal );
        }

    }
}
