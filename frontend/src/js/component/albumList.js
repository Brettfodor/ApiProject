export default function AlbumList(albumList) {
    return `
    <section id='album-list'>
    <ul>
    ${albumList
        .map(album => {
            return `
            <article class="album">
            <li>
                <h3>${album.name}</h3>
            </li>
            </article>
   
                `;
        })
        .join("")}
        </ul>
    
        <section class='add-album'>
            <input class='add-album__albumName' type='text' placeholder='Add a album!'>
            <button class='add-album__submit'>Submit</button>
         </section>
    </section>  

        
    `

}