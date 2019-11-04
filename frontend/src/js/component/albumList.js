export default function AlbumList() {
    
    let returnHtml = "";
    returnHtml += `
    <section id='album-list'>
        <article class="album">
            <h2>Album Name</2>
            <ul id="song-list">
                <li class="song-item">Song</li>
            </ul>
        </article>
    </section>
    `;
    return returnHtml;
};