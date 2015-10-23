using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeGraphHOL.Models
{


    public class Rootobject
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        [JsonProperty("@odata.nextLink")]
        public string odatanextLink { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public string odatatype { get; set; }
        public string odataid { get; set; }
        public string odataetag { get; set; }
        public string Id { get; set; }
        public string ChangeKey { get; set; }
        public string[] Categories { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeLastModified { get; set; }
        public bool HasAttachments { get; set; }
        public string Subject { get; set; }
        public Body Body { get; set; }
        public string BodyPreview { get; set; }
        public string Importance { get; set; }
        public string ParentFolderId { get; set; }
        public Sender Sender { get; set; }
        public From From { get; set; }
        public Torecipient[] ToRecipients { get; set; }
        public object[] CcRecipients { get; set; }
        public object[] BccRecipients { get; set; }
        public Replyto[] ReplyTo { get; set; }
        public string ConversationId { get; set; }
        public object IsDeliveryReceiptRequested { get; set; }
        public bool IsReadReceiptRequested { get; set; }
        public bool IsRead { get; set; }
        public bool IsDraft { get; set; }
        public DateTime DateTimeReceived { get; set; }
        public DateTime DateTimeSent { get; set; }
        public string WebLink { get; set; }
    }

    public class Body
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class Sender
    {
        public Emailaddress EmailAddress { get; set; }
    }

    public class Emailaddress
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class From
    {
        public Emailaddress1 EmailAddress { get; set; }
    }

    public class Emailaddress1
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class Torecipient
    {
        public Emailaddress2 EmailAddress { get; set; }
    }

    public class Emailaddress2
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class Replyto
    {
        public Emailaddress3 EmailAddress { get; set; }
    }

    public class Emailaddress3
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }


}