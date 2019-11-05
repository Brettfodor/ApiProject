export default function AlbumList(albums) {
    return `
    <section id='album-list'>
    ${albums
        .map(album => {
            return `
            <article class="album">
            <li>
                <h3>${album.title}</h3>
            </li>
            </article>
            `;
        })
        .join("")}
    </section>  
    `
}