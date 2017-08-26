package imdb.bindingModel;

public class FilmBindingModel {
    private String Name;
    private String Genre;
    private String Director;
    private int Year;

    public FilmBindingModel() {
    }

    public FilmBindingModel(String name, String genre, String director, int year) {
        Name = name;
        Genre = genre;
        Director = director;
        Year = year;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getGenre() {
        return Genre;
    }

    public void setGenre(String genre) {
        Genre = genre;
    }

    public String getDirector() {
        return Director;
    }

    public void setDirector(String director) {
        Director = director;
    }

    public int getYear() {
        return Year;
    }

    public void setYear(int year) {
        Year = year;
    }
}
