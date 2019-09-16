//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Core.Repository.EF.ContextStorage
//{
//    public static class ContextFactory
//    {
//        public static GalleryContext GetCurrentContext()
//        {
//            IContextStorage contextStorage = ContextStorageFactory.GetStorage();

//            ObjectContext currentContext = contextStorage.GetCurrentContext();

//            if (currentContext == null)
//            {
//                currentContext = new GalleryContext();
//                contextStorage.Store(currentContext);
//            }

//            return currentContext as GalleryContext;
//        }

//        public static void ResetCurrentContext()
//        {
//            IContextStorage contextStorage = ContextStorageFactory.GetStorage();

//            ObjectContext currentContext = contextStorage.GetCurrentContext();

//            if (currentContext != null)
//            {
//                currentContext.Dispose();

//                currentContext = new GalleryContext();
//                contextStorage.Store(currentContext);
//            }
//        }
//    }
//}
