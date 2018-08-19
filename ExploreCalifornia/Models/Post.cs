using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }

                return _key;
            }
            set { _key = value; }
        }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 character long")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Blog posts must be between at least 100 character long")]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
    }
}
