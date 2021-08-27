using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any() && context.Posts.Any() && context.PostDetails.Any()) return;

            for (var i = 0; i < 5; i++)
            {
                var userId = Guid.NewGuid();
                var postId = Guid.NewGuid();
                var sampleText =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";


                var user = new User
                {
                    UserId = userId,
                    Email = "test@test.com",
                    FullName = "Test Test",
                    Password = "testpass",
                    Username = "testuser"
                };
                await context.Users.AddAsync(user);

                var post = new Post
                {
                    Description = sampleText,
                    PostId = postId,
                    Timestamp = DateTime.Now,
                    UserId = userId,
                    Title = "Sample text"
                };
                await context.Posts.AddAsync(post);

                var postDetails = new List<PostDetail>
                {
                    new()
                    {
                        PostDetailId = Guid.NewGuid(),
                        PostId = postId,
                        Description = sampleText
                    },
                    new()
                    {
                        PostDetailId = Guid.NewGuid(),
                        PostId = postId,
                        Description = sampleText
                    },
                    new()
                    {
                        PostDetailId = Guid.NewGuid(),
                        PostId = postId,
                        Description = sampleText
                    },
                    new()
                    {
                        PostDetailId = Guid.NewGuid(),
                        PostId = postId,
                        Description = sampleText
                    }
                };
                await context.PostDetails.AddRangeAsync(postDetails);
            }

            await context.SaveChangesAsync();
        }
    }
}