#include <iostream>
#include <string>
#include <map>

class Library {
private:
    std::multimap<std::string, std::tuple<std::string, int>> books;

public:
    void addBook(const std::string& author, const std::string& title, int year) {
        books.insert({author, std::make_tuple(title, year)});
        std::cout << "Книга додана: " << title << " (" << year << ") автора " << author << std::endl;
    }

    void removeBooks(const std::string& author) {
        auto range = books.equal_range(author);
        if (range.first != range.second) {
            books.erase(range.first, range.second);
            std::cout << "Книги автора " << author << " видалено" << std::endl;
        } else {
            std::cout << "Книг автора " << author << " не знайдено" << std::endl;
        }
    }

    void searchByAuthor(const std::string& author) {
        auto range = books.equal_range(author);
        if (range.first != range.second) {
            std::cout << "Книги автора " << author << ":" << std::endl;
            for (auto it = range.first; it != range.second; ++it) {
                std::cout << "- " << std::get<0>(it->second) << " (" << std::get<1>(it->second) << ")" << std::endl;
            }
        } else {
            std::cout << "Книг автора " << author << " не знайдено" << std::endl;
        }
    }

    void searchByYear(int year) {
        bool found = false;
        for (const auto& book : books) {
            if (std::get<1>(book.second) == year) {
                if (!found) {
                    std::cout << "Книги, видані в " << year << ":" << std::endl;
                    found = true;
                }
                std::cout << "- " << std::get<0>(book.second) << " (автор " << book.first << ")" << std::endl;
            }
        }
        if (!found) {
            std::cout << "Книг, виданих в " << year << ", не знайдено" << std::endl;
        }
    }
};

int main() {
    Library library;

    library.addBook("Автор1", "Книга1", 2000);
    library.addBook("Автор2", "Книга2", 2005);
    library.addBook("Автор1", "Книга3", 2010);

    library.searchByAuthor("Автор1");

    library.searchByYear(2005);

    library.removeBooks("Автор1");

    library.searchByAuthor("Автор1");

    return 0;
}
