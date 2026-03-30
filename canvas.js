const canvas = document.getElementById("canvas")
const ctx = canvas.getContext("2d")

canvas.style.left = `${g.min_width}px`
canvas.style.top = `${g.min_height}px`
canvas.width = g.max_width
canvas.height = g.max_height

let box_size = 20
let box_pos_x = 50
let box_pos_y = 50

let margin = 2

let box_margin = box_size + margin

let grid_size_x = 50



let box = 0

let grid_x = Array.from({length: grid_size_x}, () => {
    return {...box}
})


function canvas_render() {
    grid_x.forEach((box, index) => {



        let current_x = box_pos_x + (index * box_margin)
        ctx.fillStyle = "black"
        ctx.fillRect(current_x, box_pos_y, box_size, box_size)
    })




}

