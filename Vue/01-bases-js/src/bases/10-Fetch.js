

const apiKey = 'MPnlKMtkwuQyFTPgjqurs2SJ13Tp5AwT'

fetch(`https://api.giphy.com/v1/gifs/random?api_key=${apiKey}`)
.then( resp => resp.json())
// Retorna objeto con data y meta, como solo necesitamos la data desesctructuramos
// .then( img => {
//     console.log(img)
// })
.then( ({ data }) => {
    const {url} = data.images.original

    console.log(url)
    const img = document.createElement('img')
    img.src = url

    document.body.append( img )
})