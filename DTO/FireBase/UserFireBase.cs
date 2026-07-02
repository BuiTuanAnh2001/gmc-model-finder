using gmc_api.Base.dto;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;

namespace gmc_api.DTO.FireBase
{
    [FirestoreData]
    public class UserFireBase : FireBaseID
    {
        [FirestoreProperty]
        public string content { get; set; }
        [FirestoreProperty]
        public string sndUser { get; set; }
        [FirestoreProperty]
        public string type { get; set; }
        [FirestoreProperty]
        public int objectId { get; set; }
        [FirestoreProperty]
        public DateTime sndDate { get; set; }
        [FirestoreProperty]
        public string keys { get; set; }
        public string title { get; set; }
        public string appModuleName { get; set; }
        public int inboxItemID { get; set; }
    }
}
