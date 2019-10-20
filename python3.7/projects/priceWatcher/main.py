from bs4 import BeautifulSoup
import requests
sources = {  # maybe this should be classes, but i never get the chance to use maps. May change later...
    # NHL 20 PS4
    "Komplett": BeautifulSoup(requests.get("https://www.komplett.dk/product/1132409/gaming/spil/spil-til-playstation-4/nhl-20").text, "lxml"),
    "Elgiganten": BeautifulSoup(requests.get("https://www.elgiganten.dk/product/gaming/spil/playstation-4-spil/42360/nhl-20-ps4").text, "lxml"),
    "Power": BeautifulSoup(requests.get("https://www.power.dk/gaming-og-underholdning/spil/nhl-20-ps4/p-1008038/?q=NHL20").text, "lxml"),
    "Proshop": BeautifulSoup(requests.get("https://www.proshop.dk/Spil/NHL-20-Sony-PlayStation-4-Sport/2779725").text, "lxml")
}


# find prices
print("Komplett:", sources["Komplett"].find(class_="product-price-now").text)
print("Elgiganten:", sources["Komplett"].find_next_sibling("span"))
