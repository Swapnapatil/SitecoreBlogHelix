using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System.Collections.Generic;

namespace SitecoreBlogHelix.Feature.SitecoreBlog.Models
{
    public class ArticleModel : SearchResultItem
    {
        [IndexField("_name")]
        public virtual string ItemName { get; set; } // Custom field on my template

        [IndexField("title_t")]
        public virtual string Title { get; set; } // Custom field on my template

        [IndexField("author_t")]
        public virtual string Author { get; set; }

        [IndexField("shortdescription_t")]
        public virtual string ShortDescription { get; set; } // Custom field on my template

        [IndexField("date_t")]
        public virtual string PosteDate { get; set; } // Custom field on my template
        [IndexField("category_t")]
        public virtual string Category { get; set; } // Custom field on my template
        [IndexField("articlesmallimage_t")]
        public virtual string ArticleShortImage { get; set; } // Custom field on my template

    }

    public class SearchResult
        {
        public string ItemName { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PostedDate { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string ArticleShortImage { get; set; }

    }

    public class SearchResults
    {
        public List<SearchResult> Results { get; set; }
    }
}