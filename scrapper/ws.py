from bs4 import BeautifulSoup
import requests

site = requests.get('https://www.climatempo.com.br/').content  # Objeto site recebe todo conteúdo da requisição
# http do site

soup = BeautifulSoup(site, 'html.parser')  # o objeto soup está baixando o site em html

# print(soup.prettify())  # transforma html em string e o print vai exibir o html

# temperatura = soup.find('span', class_="_block _margin-b-5 -gray")
#
# print(temperatura.string)

print(soup.title.string)
print(soup.a.string)


