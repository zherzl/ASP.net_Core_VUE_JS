//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Core.Repository.EF.ContextStorage
//{
//    public static class ContextStorageFactory
//    {
//        private static IContextStorage _contextStorage;

//        public static IContextStorage GetStorage()
//        {
//            if (_contextStorage == null)
//            {
//                if (HttpContext.Current != null)
//                {
//                    // ASP.NET.
//                    _contextStorage = new HttpContextStorage();
//                }
//                else if (System.ServiceModel.OperationContext.Current != null)
//                {
//                    // WCF.
//                    _contextStorage = new WcfInstanceContextStorage();
//                }
//                else
//                {
//                    // NUnit, FiskalizacijaSched.
//                    _contextStorage = new ThreadContextStorage();
//                }
//            }

//            return _contextStorage;
//        }
//    }
//}
