import React from 'react';
import { Button, Item, Segment } from 'semantic-ui-react';
import { Post } from '../../../app/models/post';

interface Props {
  posts: Post[];
}

export default function PostList({ posts }: Props) {
  return (
    <Segment>
      <Item.Group divided>
        {posts.map((post) => (
          <Item key={post.postId}>
            <Item.Image size='medium' src='https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/slideshows/great_food_combos_for_losing_weight_slideshow/650x350_great_food_combos_for_losing_weight_slideshow.jpg' />
            <Item.Content>
              <Item.Header as="a">{post.title}</Item.Header>
              <Item.Meta>{post.timestamp}</Item.Meta>
              <Item.Description>
                <div>{post.description}</div>
              </Item.Description>
              <Item.Extra>
                <Button floated="right" content="View" color="blue" />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </Segment>
  );
}
