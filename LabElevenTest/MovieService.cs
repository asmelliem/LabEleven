using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LabElevenTest
{
    public class MovieService
    {       
        static List<LabEleven.Movie> movies = LabEleven.MovieService.GenerateMovieList();
        static List<string> animatedMovies = LabEleven.MovieService.ReturnMovieList(movies, 1);
        static List<string> dramaMovies = LabEleven.MovieService.ReturnMovieList(movies, 2);
        static List<string> horrorMovies = LabEleven.MovieService.ReturnMovieList(movies, 3);
        static List<string> scifiMovies = LabEleven.MovieService.ReturnMovieList(movies, 4);

        [Fact]
        public void SetCategoryChoiceAnimated()
        {
            var actual = LabEleven.MovieService.SetCategoryChoice(1);
            var expected = "Animated";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCategoryChoiceDrama()
        {
            var actual = LabEleven.MovieService.SetCategoryChoice(2);
            var expected = "Drama";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCategoryChoiceHorror()
        {
            var actual = LabEleven.MovieService.SetCategoryChoice(3);
            var expected = "Horror";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCategoryChoiceScifi()
        {
            var actual = LabEleven.MovieService.SetCategoryChoice(4);
            var expected = "Scifi";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnMovieListAnimated()
        {
            var actual = LabEleven.MovieService.ReturnMovieList(movies, 1);
            var expected = new List<string>() { "Pokemon", "Frozen", "Weathering with You" };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnMovieListDrama()
        {
            var actual = LabEleven.MovieService.ReturnMovieList(movies, 2);
            var expected = new List<string>() { "Rocketman", "Little Women" };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnMovieListHorror()
        {
            var actual = LabEleven.MovieService.ReturnMovieList(movies, 3);
            var expected = new List<string>() { "The Grudge", "The Conjuring", "IT" };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnMovieListScifi()
        {
            var actual = LabEleven.MovieService.ReturnMovieList(movies, 4);
            var expected = new List<string>() { "Star Wars", "Minority Report" };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrintAlphabeticalMovieListAnimated()
        {
            var actual = LabEleven.MovieService.PrintAlphabeticalMovieList(animatedMovies);
            var expected = new StringBuilder("Frozen\nPokemon\nWeathering with You\n");

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void PrintAlphabeticalMovieListDrama()
        {
            var actual = LabEleven.MovieService.PrintAlphabeticalMovieList(dramaMovies);
            var expected = new StringBuilder("Little Women\nRocketman\n");

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void PrintAlphabeticalMovieListHorror()
        {
            var actual = LabEleven.MovieService.PrintAlphabeticalMovieList(horrorMovies);
            var expected = new StringBuilder("IT\nThe Conjuring\nThe Grudge\n");

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void PrintAlphabeticalMovieListScifi()
        {
            var actual = LabEleven.MovieService.PrintAlphabeticalMovieList(scifiMovies);
            var expected = new StringBuilder("Minority Report\nStar Wars\n");

            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
