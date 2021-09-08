using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management!");
            Console.WriteLine("-------------------------------------");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true },
                new ProductReview(){ProductId=2,UserId=1,Rating=4,Review="Good",isLike=true },
                new ProductReview(){ProductId=3,UserId=2,Rating=5,Review="Good",isLike=true },
                new ProductReview(){ProductId=4,UserId=2,Rating=4,Review="Good",isLike=true },
                new ProductReview(){ProductId=5,UserId=3,Rating=2,Review="Nice",isLike=false},
                new ProductReview(){ProductId=6,UserId=4,Rating=1,Review="Bad",isLike=false },
                new ProductReview(){ProductId=7,UserId=3,Rating=1,Review="Nice",isLike=false },
                new ProductReview(){ProductId=8,UserId=10,Rating=9,Review="Nice",isLike=true },
                new ProductReview(){ProductId=9,UserId=10,Rating=10,Review="Nice",isLike=true },
                new ProductReview(){ProductId=10,UserId=10,Rating=8,Review="Nice",isLike=true },
                new ProductReview(){ProductId=11,UserId=10,Rating=3,Review="Nice",isLike=true },
                new ProductReview(){ProductId=12,UserId=10,Rating=7,Review="Nice",isLike=true },
                new ProductReview(){ProductId=13,UserId=10,Rating=2,Review="Nice",isLike=true },
                new ProductReview(){ProductId=14,UserId=10,Rating=4,Review="Nice",isLike=true },
                new ProductReview(){ProductId=15,UserId=10,Rating=4,Review="Nice",isLike=true },
                new ProductReview(){ProductId=16,UserId=10,Rating=4,Review="Nice",isLike=true }
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId:- " + list.ProductId + " " + "UserId:- " + list.UserId
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike :- " + list.isLike);
            }

        }
    }
}