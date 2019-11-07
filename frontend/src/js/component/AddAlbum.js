
export default function AddAlbums(artists) {
    return `
    <ul>
            ${artists
              .map(artist => {
                return `
                    <select name="artistName">
                    <option value="${artist.Id}">${artist.name}</option>
                    </select>
                `;
              })
              .join("")}
         </ul>
         <section class="add-album">
            <input class="add-album__albumtitle" type="text" placeholder="Add an album!">
            <input class="add-album__artistname" type="dropdown" value="${artist.name}">
            <input class="add-album__artistId" type="hidden" value="${artist.Id}">
            <button class="add-album__submit">Click Here To Add Album!</button>
        </section>
    `
}