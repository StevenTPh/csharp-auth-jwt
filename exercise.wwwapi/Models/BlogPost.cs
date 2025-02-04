﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.Models
{
    [Table("blogposts")]
    public class BlogPost
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("text")]
        public string Text { get; set; }

        [ForeignKey("author_id")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}