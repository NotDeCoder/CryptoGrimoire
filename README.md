# CryptoGrimoire
_A simple tool for monitoring currency and cryptocurrency prices on various exchanges_
___
### "What will this project be?"
With the help of this service, it will be possible to find out the current rates of trading pairs of different exchanges. Calculate where it is best to exchange one (crypto)currency for another.


Each trading pair will have its own page, which will display the average exchange rate, 24-hour rise / fall, trading volume, availability of input/output of currency from the exchange ... At the bottom of the page there will be a more detailed summary of this trading pair on various exchanges


A calculator will also be added, which will tell you where it is most profitable to exchange one pair currency for another. The calculation will be based on exchange orders, and not on the current buy / sell rate, which makes the calculator more accurate than the rest
___
More detailed description of features:

Each trading pair will have its own page, it will contain a photo, name, description of the trading pair. Below is a table that shows information about rates, volumes, etc. of a trading pair on various exchanges. This information will be updated every second 2-3 times. This should be done via a websocket. Information about the parameters of the pair (rate, volume, last price) comes from the exchange, and the same information is displayed to the user instantly. We also copy this information to the database in order to use it for our own API (The user wants to know something about a certain pair, requests this from the API, which takes this information from the database and responds to the user). After this table there will be a calculator. In it, the user enters how much of one currency he wants to exchange for another currency. At the click of a button, using the API, we get all orders (buy or sell) of this pair on various exchanges. The average transaction price and the amount of currency that the user will eventually receive are considered. We display this data to the user in the form of a table.


___
For now, that's all. I will try to refine this project in the near future
