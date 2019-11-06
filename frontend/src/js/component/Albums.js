// export default function AlbumList(albums) {
//     return `
//     <section id='album-list'>
//     ${albums
//         .map(album => {
//             return `
//             <article class="album">
//             <li>
//                 <h3>${album.title}</h3>
//             </li>
//             </article>
//             `;
//         })
//         .join("")}
//     </section>  
//     `


export default function Albums(albums, artists) {
    return `
    <ul>
            ${albums
              .map(album => {
                return `
                    <li>
                        <h3>${album.title}</h3>
                        <img src=${album.image}></img>
                        <input class="album__id" type="hidden" value="${album.id}">
                        <button class="edit-album__submit" >Edit</button>
                        <button class="delete-album__submit">Delete</button>
                    </li>
                `;
              })
              .join("")}
         </ul>
         <div id="album-form"></div>
    `
}