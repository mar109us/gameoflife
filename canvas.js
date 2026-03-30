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

let box_margin_x = box_size + margin
let box_margin_y = box_size + margin

let grid_size_x = 50



let box = 0

let grid_x = Array.from({length: grid_size_x}, () => {
    return {...box}
})

let index_per_line = 0
function canvas_render() {
    grid_x.forEach((box, index) => {

        let current_y = box_margin_y

        if (index_per_line == 10) {
            index_per_line = 0
            current_y += box_margin_y
        }
        
        index_per_line += 1



        let current_x = box_pos_x + (index * box_margin_x)
        ctx.fillStyle = "black"
        ctx.fillRect(current_x, current_y, box_size, box_size)
    })




}

