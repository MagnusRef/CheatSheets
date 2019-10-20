# install selenium via pip3
from selenium import webdriver
brw = webdriver.Firefox(executable_path='./geckodriver')
brw.get("http://duckduckgo.com/")
searchbar = brw.find_element_by_id("search_form_input_homepage")
searchbar.send_keys("am I a bot?")
searchgo = brw .find_element_by_id("search_button_homepage")
searchgo.click()
