using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class LikesRepository : Repository<Likes>
        {
            public List<Likes> GetByMedia(int mediaId)
                => ToList().Where(l => l.MediaId == mediaId).ToList();

            public Likes GetUserLike(int mediaId, int userId)
                => ToList().FirstOrDefault(l => l.MediaId == mediaId && l.UserId == userId);

            public void DeleteByMedia(int mediaId)
            {
                foreach (var like in GetByMedia(mediaId))
                    base.Delete(like.Id);
            }

            public void DeleteByUser(int userId)
            {
                foreach (var like in ToList().Where(l => l.UserId == userId).ToList())
                    base.Delete(like.Id);
            }
        }
}