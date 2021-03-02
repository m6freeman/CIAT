
# Import requests, to make http requests, asyncio to handle async, and timeit to prove our point
import requests
import asyncio
from timeit import default_timer

# Let's just grab a few responses from Duckduckgo.
# We could do Google, but we're not monsters.
url = "https://duckduckgo.com/?q="
# And populate a list with each url, searching for numbers 0-19 (as an example)
urls = [url + str(x) for x in range(20)]

# This function will reach out to the url provided and return our HTTP response code
# (we could return other things, but for brevity we'll just look at responses)
def fetch(session, url):
    with session.get(url) as response:
        return response.status_code

# This will be our asynchronous version of the function to loop through each url,
# pass it to the fetch() function, which in turn must wait for communication
async def fetch_urls_async(urls):
    with requests.Session() as session:
        loop = asyncio.get_event_loop()
        tasks = [loop.run_in_executor(None, fetch, session, url) for url in urls]
        for response in await asyncio.gather(*tasks):
            print(response)

#This is the synchronous version of the function above.
# It does the same thing, except we'll have to wait in between each request.
def fetch_urls_sync(urls):
    with requests.Session() as session:
        for url in urls:
            print(fetch(session, url))

# Actually execute the functions above in Main()
def main():
    start = default_timer()
    fetch_urls_sync(urls)
    elapsed = default_timer() - start
    print(elapsed, "seconds")
    start = default_timer()
    asyncio.run(fetch_urls_async(urls))
    elapsed = default_timer() - start
    print(elapsed, "seconds")


# Call main() only if this module is being called by itself and not from another script
if __name__ == "__main__":
    main()
