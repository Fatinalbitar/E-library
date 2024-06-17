using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    public class StudentBorrowBooks
    {
        public int Id { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? RecievedDate { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
