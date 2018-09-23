using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        private int _vote;

        public void Upvote()
        {
            _vote++;
        }

        public void Downvote()
        {
            _vote--;
        }

        public int GetVoteValue()
        {
            return _vote;
        }
    }
}