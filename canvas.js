const canvas = document.getElementById("canvas")
const ctx = canvas.getContext("2d")

canvas.style.left = `${g.min_width}px`
canvas.style.top = `${g.min_height}px`
canvas.width = g.max_width
canvas.height = g.max_height

let box_size = 20
let box_pos_x = 50
let box_pos_y = 50

let margin = 1

let box_margin_x = box_size + margin
let box_margin_y = box_size + margin

let grid_size_x = 1

let box = 0

/* let grid_x = Array.from({length: grid_size_x}, () => {
    return {...box}
}) */

let grid_x = Array.from({length: grid_size_x}, () => {
    return {...box}
})

let current_y = box_margin_y
let index_per_line = 0

let max_column = 10
let max_row = 10
let current_collums = 0

let gridpos_x = 0
let gridpos_y = 0

function canvas_render() {
    grid_x.forEach((box) => {

        let current_x = box_pos_x + (index_per_line * box_margin_x)
        

        if (index_per_line == 5)  {
            ctx.fillStyle='rgb(78, 89, 83)'
        }
        if (box > 10) {
            ctx.fillStyle='rgb(39, 46, 44)'
        }

        if (current_collums < max_column) {
        ctx.fillRect(current_x, current_y, box_size, box_size)
        index_per_line += 1
        }

        if (index_per_line == max_row) {
            index_per_line = 0
            current_collums += 1
            current_y += box_margin_y
            current_x = box_margin_x
        }

    })

}

