// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(async () => {
    await sampleGet();
    async function sampleGet() {
        var response = await fetch("https://localhost:7173/api/Test/SampleGet");
        console.log(response);
        //var result = await response.json();
        //console.log(result);
    }

    await samplePostFromBody();
    async function samplePostFromBody() {
        var response = await fetch("https://localhost:7173/api/Test/SamplePostFromBody", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ Num: 1, String: 'Textual content' })
        });
        console.log(response);
    }

    await samplePostFromQuery();
    async function samplePostFromQuery() {
        var response = await fetch("https://localhost:7173/api/Test/SamplePostFromQuery?query=query&num=3", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        console.log(response);
    }

    await combined();
    async function combined() {
        var response = await fetch("https://localhost:7173/api/Test/Combined?num=9", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ Num: 1000, String: 'Textual content' })
        });
        console.log(response);
    }

    //https://localhost:7173/api/Test/SamplePostFromQuery?query=query&num=1

    //[HttpPost]
    //[Route("SamplePostFromQuery")]
    //    public async Task < IActionResult > SamplePostFromQuery(string query, int num)
    //{
    //    await Task.Delay(1);
    //    return Ok($"Successfull SamplePostFromQuery call! Query: {query}, num: {num}");
    //}
})();



