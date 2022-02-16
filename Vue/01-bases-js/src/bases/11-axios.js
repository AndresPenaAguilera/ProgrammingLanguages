import axios from 'axios'

const apiKey = 'MPnlKMtkwuQyFTPgjqurs2SJ13Tp5AwT'

const githyApi = axios.create({
    baseURL:'https://api.giphy.com/v1/gifs',
    params:{
        api_key:apiKey
    }
})

export default githyApi
/*
githyApi.get('/random')
.then(resp => {
    const { data } = resp.data
    const { url } = data.images.original

    console.log(resp.data.data.images.original.url)
    
    const img = document.createElement('img')
    img.src = url
    document.body.append(img)
})
*/