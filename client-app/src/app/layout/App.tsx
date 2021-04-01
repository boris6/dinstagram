import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container } from 'semantic-ui-react';
import { Post } from '../models/post';
import PostDashboard from '../../features/posts/dashboard/PostDashboard';

function App() {
  const [posts, setPosts] = useState<Post[]>([]);

  useEffect(() => {
    axios
      .get<Post[]>('http://localhost:5000/api/post')
      .then((response) => {
        console.log(response);
        setPosts(response.data);
      });
  }, []);

  return (
    <>
      <Container style={{ marginTop: '7em' }}>
        <PostDashboard posts={posts} />
      </Container>
    </>
  );
}

export default App;
