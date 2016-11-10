﻿using SimpleFramework.Core.Abstraction.Entitys;
using System.ComponentModel.DataAnnotations;


namespace SimpleFramework.Core.Entitys
{
    public class NotificationTemplateEntity : EntityWithCreatedAndUpdatedMeta<long>
    {
        /// <summary>
        /// Id of object that create notification
        /// </summary>
        [StringLength(128)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Id of notification type
        /// </summary>
        [StringLength(128)]
        public string NotificationTypeId { get; set; }

        public string Sender { get; set; }
        public string Recipient { get; set; }
        /// <summary>
        /// Subject of notification
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Body of notification
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Engine that resolve this template
        /// </summary>
        [StringLength(64)]
        public string TemplateEngine { get; set; }

        /// <summary>
        /// Type of object that work with this template
        /// </summary>
        [StringLength(128)]
        public string ObjectTypeId { get; set; }

        /// <summary>
        /// Language of template
        /// </summary>
        [StringLength(10)]
        public string Language { get; set; }

        /// <summary>
        /// Is that template default
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
