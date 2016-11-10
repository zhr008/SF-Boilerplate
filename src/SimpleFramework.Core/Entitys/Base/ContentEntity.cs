﻿using System;
using SimpleFramework.Core.Abstraction.Entitys;

namespace SimpleFramework.Core.Entitys
{
    public abstract class ContentEntity : EntityWithCreatedAndUpdatedMeta<long>
    {
        private bool isDeleted;

        protected ContentEntity()
        {

        }

        public string Name { get; set; }

        public string SeoTitle { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public bool IsPublished { get; set; }

        public DateTimeOffset? PublishedOn { get; set; }

        public bool IsDeleted
        {
            get
            {
                return isDeleted;
            }

            set
            {
                isDeleted = value;
                if (value)
                {
                    IsPublished = false;
                }
            }
        }

    }
}
