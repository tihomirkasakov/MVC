package imdb.entity;

import javax.persistence.*;

@Entity
@Table(name = "films")
public class Film {
	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int Id;
	private String Name;
	private String Genre;
	private String Director;
	private int Year;

    public Film() {
    }

    public Film(String name, String genre, String director, int year) {
        Name = name;
        Genre = genre;
        Director = director;
        Year = year;
    }

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    @Column(nullable = false)
    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    @Column(nullable = false)
    public String getGenre() {
        return Genre;
    }

    public void setGenre(String genre) {
        Genre = genre;
    }

    @Column(nullable = false)
    public String getDirector() {
        return Director;
    }

    public void setDirector(String director) {
        Director = director;
    }

    @Column(nullable = false)
    public int getYear() {
        return Year;
    }

    public void setYear(int year) {
        Year = year;
    }
}
