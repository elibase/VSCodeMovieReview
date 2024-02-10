﻿using VSCodeMovieReview.Models;

namespace VSCodeMovieReview.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}