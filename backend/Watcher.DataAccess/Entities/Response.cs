namespace Watcher.DataAccess.Entities
{
    using System;

    public class Response : Entity<int>
    {
        public override int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int FeedbackId { get; set; }
        public Feedback Feedback { get; set; }
    }
}
