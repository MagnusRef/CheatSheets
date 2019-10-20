from bs4 import BeautifulSoup
import requests

with open("index.html") as html_file:
    soup = BeautifulSoup(html_file, 'lxml')

# title
webTitle = soup.title
print("With tags:", webTitle)
print("without tags:", webTitle.text)

# first div in the file
firstDiv = soup.div
#print(firstDiv) # with child tags

# find specific div (jumbotron)
jumbotron = soup.find("div", class_="jumbotron")
print(jumbotron)
# find the h1 tag in the jumbotron
headerline = jumbotron.h1.text
jumboLink = soup.find("p", class_="mb-0").a  # find the link in the jumbotron!
print(headerline) # amazing
print(jumboLink)

# find all
allBtn = soup.find_all(class_="btn")
print("all tags with btn class:")
for Btn in allBtn:
    print(Btn.text)

# now for a "real" website using requests module
# docker pull nginx && docker create --nmae c-nignx -p 8080:80 nginx && docker start c-nginx
source = requests.get("http://192.168.2.12:8080").text # nginx docker instance
nginx = BeautifulSoup(source, "lxml")


print(nginx.find("a")['href'])





