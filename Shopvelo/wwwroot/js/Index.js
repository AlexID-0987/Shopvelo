function create(bake) {
    const tr = document.createElement('tr')
    const model = document.createElement('th')
    model.append(bake.model)
    tr.append(model)
    const name = document.createElement('th')
    name.append(bake.name)
    tr.append(name)
    const color = document.createElement('th')
    color.append(bake.color)
    tr.append(color)
    const im = document.createElement('th')
    im.append(bake.price)
    tr.append(im)
    const fo = document.createElement('th')
    fo.append(bake.foto)
    tr.append(fo)

    return tr
}

//console.log(create({
//    "Name": "ytr",
//    "Model": "revxb",
//    "Price":12.4565
//}))

async function getbake() {
    const resp = await fetch('/api/bakes')
    if (resp.ok === true) {
        const ba = await resp.json()
        let rows = document.querySelector('tbody')
        ba.forEach(bake=>rows.append(create(bake)))
    }
}
getbake()