export default function Albums(albums, artists) {
    return `
    <section class="add-album">
        <select class="add-album__artistId">
        ${artists
            .map(artist=>{
                return`
                    <option value="${artist.id}">${artist.name}</option>
                `
            }).join("")}
        </select>
        <input class="add-album__albumtitle" type="text" placeholder="Add an album!">
        <button class="add-album__submit">Submit</button>
    </section>
    `
}